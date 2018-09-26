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
    public partial class CreateTrigger : Form
    {
        public CreateTrigger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = tbName.Text;
            String time = tbTiempo.Text;
            String crud = tbCrud.Text;
            String func = tbFuncion.Text;
            String tabla = tbTabla.Text;
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username=" + ConnectionManager.usuario + ";" +
                    "Password=" + ConnectionManager.password + ";Database=" + ConnectionManager.usuario))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CREATE TRIGGER " +name 
                            + " "+ time + " " + crud + " ON " +tabla
                            + " FOR EACH ROW"
                            + " EXECUTE PROCEDURE "+func+ "();";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trigger creado");
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
