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
        NpgsqlCommandBuilder commandBuilder;
        BindingSource bs = new BindingSource();

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
                commandBuilder = new NpgsqlCommandBuilder(da);
                ds.Reset();
                da.Fill(ds,nomTabla);
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
            updateState();
        }

        /*private String insertarTabla()
        {
            String nomTabla = tbTabla.Text;
            var statement = "INSERT INTO " + nomTabla + " VALUES(";
            DataGridViewRow row = dataGridView1.Rows[this.dataGridView1.RowCount - 2];
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                if (i != 0)
                {
                    statement += ",";
                }
                statement += $@" '{row.Cells[i].Value}'";
            }
            statement += ")";
            return statement;
        }*/

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

        private void bEliminarTabla_Click(object sender, EventArgs e)
        {
            String nomTabla = tbTabla.Text;
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
                        cmd.CommandText = "DROP TABLE " + nomTabla;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Se elimino tabla exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            updateState();
        }

        private void bBorrarF_Click(object sender, EventArgs e)
        {
            String tableName = tbTabla.Text;
            String pk = dataGridView1.CurrentCell.Value.ToString();
            String columnName = dataGridView1.Columns[0].HeaderText;
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
                        cmd.CommandText = "delete from " + tableName + " where " + columnName + "=" + pk; ;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se elimino fila exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateState()
        {
            try
            {
                String tableName = tbTabla.Text;
                da.Update(ds, tableName);
                MessageBox.Show("Datos actualizados");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
