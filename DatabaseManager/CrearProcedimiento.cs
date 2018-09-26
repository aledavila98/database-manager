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
    public partial class CrearProcedimiento : Form
    {
        public CrearProcedimiento()
        {
            InitializeComponent();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            String nomProcedure = tbNombreP.Text;
            String retorno;
            if (tbTipoRetorno.Text.Equals(""))
                retorno = "void";
            else
                retorno = tbTipoRetorno.Text;
            String parametros = tbParametros.Text;
            String codigo = tbCodigo.Text;
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username="+ConnectionManager.usuario+";" +
                    "Password="+ConnectionManager.password+";Database="+ConnectionManager.usuario))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CREATE FUNCTION " + nomProcedure + "("
                            + parametros + ") "
                            + "RETURNS " + retorno + " AS $$ "
                            + "BEGIN " + codigo
                            + " END; $$ LANGUAGE PLPGSQL";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Funcion creada");
                    }
                }
            } catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
