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
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                string sql = "select indexname from pg_indexes where schemaname='public';";
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
            }
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
                string sql = "SELECT tc.constraint_name, tc.constraint_type,tc.table_name, kcu.column_name, tc.is_deferrable, tc.initially_deferred, " +
                            "rc.match_option AS match_type, rc.update_rule AS on_update, rc.delete_rule AS on_delete, ccu.table_name AS references_table, " +
                            "ccu.column_name AS references_field " +
                            "FROM information_schema.table_constraints tc " +
                            "LEFT JOIN information_schema.key_column_usage kcu " +
                            "ON tc.constraint_catalog = kcu.constraint_catalog " +
                            "AND tc.constraint_schema = kcu.constraint_schema " +
                            "AND tc.constraint_name = kcu.constraint_name " +
                            "LEFT JOIN information_schema.referential_constraints rc " +
                            "ON tc.constraint_catalog = rc.constraint_catalog " +
                            "AND tc.constraint_schema = rc.constraint_schema " +
                            "AND tc.constraint_name = rc.constraint_name " +
                            "LEFT JOIN information_schema.constraint_column_usage ccu " +
                            "ON rc.unique_constraint_catalog = ccu.constraint_catalog " +
                            "AND rc.unique_constraint_schema = ccu.constraint_schema " +
                            "AND rc.unique_constraint_name = ccu.constraint_name " +
                            "WHERE lower(tc.constraint_type) in ('foreign key');";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView2.DataSource = dt;
                conn.Close();
            } catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
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
