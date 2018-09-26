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
    public partial class CreateView : Form
    {
        public CreateView()
        {
            InitializeComponent();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            String nombre = tbNombre.Text;
            String code = richTextBox1.Text;
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
                        cmd.CommandText = "CREATE OR REPLACE VIEW " + nombre + " AS " + code + ";";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se creo view exitosamente");
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
