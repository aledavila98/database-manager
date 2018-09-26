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
    public partial class Constraint : Form
    {
        String llave;
        public Constraint(String k)
        {
            llave = k;
            InitializeComponent();
        }

        private void Constraint_Load(object sender, EventArgs e)
        {

        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            String childT = tbChildT.Text;
            String constName = tbNameC.Text;
            String parentT = tbParentT.Text;
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
                        cmd.CommandText = "ALTER TABLE "+ childT +" ADD CONSTRAINT "+
                            constName +" FOREIGN KEY("+llave+") REFERENCES "+parentT+"("+llave+");" ;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Constraint creado");
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
