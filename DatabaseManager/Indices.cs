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
    public partial class Indices : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public Indices()
        {
            InitializeComponent();
        }

        private void bVerIndex_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", ConnectionManager.usuario,
                    ConnectionManager.password, ConnectionManager.usuario);
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "select n.nspname as schema," +
                            "t.relname as table " +
                            ",c.relname as index " +
                            "from " +
                            "pg_catalog.pg_class c " +
                            "join pg_catalog.pg_namespace n on n.oid = c.relnamespace " +
                            "join pg_catalog.pg_index i  on i.indexrelid = c.oid " +
                            "join pg_catalog.pg_class t  on i.indrelid = t.oid " +
                            "where " +
                            "c.relkind = 'i' " +
                            "and n.nspname not in ('pg_catalog', 'pg_toast') " +
                            "and pg_catalog.pg_table_is_visible(c.oid) " +
                            "order by " +
                            "n.nspname" +
                            ",t.relname" +
                            ",c.relname";
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

        private void bRegresar_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            IndexesConstraints indexes = new IndexesConstraints();
            indexes.Show();
            this.Hide();
        }
    }
}
