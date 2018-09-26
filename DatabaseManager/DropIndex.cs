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
    public partial class DropIndex : Form
    {
        public DropIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titleIdx = textBox1.Text;
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
                        cmd.CommandText = "DROP INDEX "+titleIdx+"; ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se borro index exitosamente");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
