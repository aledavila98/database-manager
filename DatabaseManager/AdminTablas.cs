using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseManager
{
    public partial class AdminTablas : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        NpgsqlConnection conn;
        NpgsqlDataAdapter da;
        String valoresTabla;

        public AdminTablas()
        {
            InitializeComponent();
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tablas tablas = new Tablas();
            tablas.Show();
            this.Hide();
        }

        private void bVerTabla_Click(object sender, EventArgs e)
        {
            String nomTabla = tbTabla.Text;
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", ConnectionManager.usuario,
                    ConnectionManager.password, ConnectionManager.usuario);
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT * FROM "+nomTabla+";";
                da = new NpgsqlDataAdapter(sql, conn);
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

        private void bSubmit_Click(object sender, EventArgs e)
        {
            foreach(DataGridView dgv in dataGridView1.Rows)
            {
                foreach (DataGridViewCell dgvc in dgv.Columns)
                {
                    
                }
            }
        }

        private void insertarTabla()
        {
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
                        cmd.CommandText = "CREATE TABLE " + tableName + "(" + columnas + ")";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Se creo tabla exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void bGenerar_Click(object sender, EventArgs e)
        {
            String nomTabla = tbTabla.Text;
            String commandToExecute = "pg_dump -t "+nomTabla+" "+ConnectionManager.usuario+ " > F:/DatabaseManager/DDLs/" +nomTabla+".sql";


            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(commandToExecute);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            MessageBox.Show("DDL generado exitosamente");

        }

        private void bVer_Click(object sender, EventArgs e)
        {
            String nomTabla = tbTabla.Text;
            VerDDL verDDL = new VerDDL(nomTabla);
            verDDL.ShowDialog();
        }
    }
}
