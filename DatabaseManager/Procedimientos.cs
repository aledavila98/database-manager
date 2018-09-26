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
    public partial class Procedimientos : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public Procedimientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
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
                string sql = "SELECT routines.routine_name, parameters.data_type, parameters.ordinal_position"
                            +" FROM information_schema.routines"
                            +" LEFT JOIN information_schema.parameters ON routines.specific_name = parameters.specific_name"
                            +" WHERE routines.specific_schema = 'public'"
                            +" ORDER BY routines.routine_name, parameters.ordinal_position;";
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

        private void bCrear_Click(object sender, EventArgs e)
        {
            CrearProcedimiento cp = new CrearProcedimiento();
            cp.ShowDialog();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                String columnName = dataGridView1.CurrentCell.Value.ToString();
                String sql = "select prosrc from pg_proc where proname like '" + columnName + "';";
                ModifyFunction modify = new ModifyFunction(sql,columnName);
                modify.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            String columnName = dataGridView1.CurrentCell.Value.ToString();
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username=" + ConnectionManager.usuario + ";" +
                    "Password=" + ConnectionManager.password + ";Database=" + ConnectionManager.usuario))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DROP FUNCTION IF EXISTS "+columnName+";";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Funcion eliminada");
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
