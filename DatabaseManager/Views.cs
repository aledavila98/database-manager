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
    public partial class Views : Form
    {
        public Views()
        {
            InitializeComponent();
        }

        private void bList_Click(object sender, EventArgs e)
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
                string sql = "select schemaname, viewname from pg_catalog.pg_views "+
                            "where schemaname NOT IN('pg_catalog', 'information_schema') "+
                            "order by schemaname, viewname; ";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (NpgsqlException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void bViews_Click(object sender, EventArgs e)
        {
            CreateView createView = new CreateView();
            createView.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            String columnName = dataGridView1.CurrentCell.Value.ToString();
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
                        cmd.CommandText = "DROP VIEW " + columnName+ ";";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se elimino view exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
