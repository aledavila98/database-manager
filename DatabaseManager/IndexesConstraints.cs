using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseManager
{
    public partial class IndexesConstraints : Form
    {
        DataSet ds1 = new DataSet();
        DataTable dt1 = new DataTable();
        String tableName;
 
        public IndexesConstraints()
        {
            InitializeComponent();
            FillTable();
        }

        private void bSelecTabla_Click(object sender, EventArgs e)
        {
            tableName = dataGridView1.CurrentCell.Value.ToString();
            String sql = "SELECT column_name " +
                            "FROM information_schema.columns " +
                            "WHERE table_schema = 'public' " +
                            "AND table_name = '" + tableName + "';";
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", ConnectionManager.usuario,
                    ConnectionManager.password, ConnectionManager.usuario);
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds1.Reset();
                da.Fill(ds1);
                dt1 = ds1.Tables[0];
                dataGridView2.DataSource = dt1;
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void FillTable()
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", ConnectionManager.usuario,
                    ConnectionManager.password, ConnectionManager.usuario);
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                string sql = "SELECT c.relname AS Tables_in FROM pg_catalog.pg_class c" +
                    " LEFT JOIN pg_catalog.pg_namespace n ON n.oid = c.relnamespace" +
                    " WHERE pg_catalog.pg_table_is_visible(c.oid)" +
                    " AND c.relkind = 'r'" +
                    "AND relname NOT LIKE 'pg_%'" +
                    "ORDER BY 1";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void bCrearInd_Click(object sender, EventArgs e)
        {
            String columnName = dataGridView2.CurrentCell.Value.ToString();
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username=" + ConnectionManager.usuario +
                ";Password=" + ConnectionManager.password +
                ";Database=" + ConnectionManager.usuario))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CREATE UNIQUE INDEX "+tableName+"_idx ON "+tableName+" ("+columnName+");";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se creo indice exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Indices indices = new Indices();
            indices.Show();
            this.Hide();
        }

        private void bCrearCons_Click(object sender, EventArgs e)
        {
            String columnName = dataGridView2.CurrentCell.Value.ToString();
            Constraint constraint = new Constraint(columnName);
            constraint.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DropTable drop = new DropTable("");
            drop.ShowDialog();
        }

        private void bDeleteIdx_Click(object sender, EventArgs e)
        {
            DropIndex drop = new DropIndex();
            drop.ShowDialog();
        }
    }
}
