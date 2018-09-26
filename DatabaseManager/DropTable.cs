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
    public partial class DropTable : Form
    {
        String llave;
        public DropTable(String k)
        {
            llave = k;
            InitializeComponent();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            String childT = textBox1.Text;
            String foreign = textBox2.Text;
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
                        cmd.CommandText = "ALTER TABLE "+childT+" DROP CONSTRAINT "+foreign+";";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se borro constraint exitosamente");
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
