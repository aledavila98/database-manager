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
    public partial class ModifyFunction : Form
    {
        String query;
        String functionName;
        public ModifyFunction(String q, String nom)
        {
            InitializeComponent();
            query = q;
            functionName = nom;
            FillTextBox();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            String nomProcedure = functionName;
            String retorno;
            if (tbReturn.Text.Equals(""))
                retorno = "void";
            else
                retorno = tbReturn.Text;
            String parametros = tbParams.Text;
            String codigo = tbModifyFunction.Text;
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username=" + ConnectionManager.usuario + ";" +
                    "Password=" + ConnectionManager.password + ";Database=" + ConnectionManager.usuario))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CREATE OR REPLACE FUNCTION " + nomProcedure + "("
                            + parametros + ") "
                            + "RETURNS " + retorno + " AS $$ "
                            + "BEGIN " + codigo
                            + " END; $$ LANGUAGE PLPGSQL";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Funcion modificada");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void FillTextBox()
        {
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Username=" + ConnectionManager.usuario + ";" +
                    "Password=" + ConnectionManager.password + ";Database=" + ConnectionManager.usuario))
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        String codigo = reader[0].ToString();
                        tbModifyFunction.Text = codigo;
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
