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
    public partial class Columna : Form
    {
        String tabla;
        public Columna(String t)
        {
            InitializeComponent();
            tabla = t;
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            String nombreColumna = tbNombre.Text;
            String tipo = textBox1.Text;
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
                        cmd.CommandText = "ALTER TABLE "+tabla+" ADD COLUMN "+nombreColumna+" "+tipo+";";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se creo columna exitosamente");
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
