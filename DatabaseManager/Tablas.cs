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
    public partial class Tablas : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public Tablas()
        {
            InitializeComponent();
        }

        private void Tablas_Load(object sender, EventArgs e)
        {

        }

        private void bListar_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", ConnectionManager.usuario,
                    ConnectionManager.password, ConnectionManager.usuario);
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT table_schema,table_name FROM information_schema.tables ORDER BY table_schema, table_name;";
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

        private void bCrearTabla_Click(object sender, EventArgs e)
        {
            CrearTabla crear = new CrearTabla();
            crear.Show();
            this.Hide();
        }

        private void bAdminTablas_Click(object sender, EventArgs e)
        {
            AdminTablas admin = new AdminTablas();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
