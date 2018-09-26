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
    public partial class CrearTabla : Form
    {
        public CrearTabla()
        {
            InitializeComponent();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            String tableName = tbNomTabla.Text;
            String columnas = listarColumnas();
            //MessageBox.Show(columnas);
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
            } catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private String listarColumnas()
        {
            int cantColumnas = int.Parse(tbCantColumnas.Text);
            TextBox[] columnas = new TextBox[6];
            columnas[0] = tbNomColumna1;
            columnas[1] = tbNomColumna2;
            columnas[2] = tbNomColumna3;
            columnas[3] = tbNomColumna4;
            columnas[4] = tbNomColumna5;
            columnas[5] = tbNomColumna6;
            TextBox[] tipos = new TextBox [6];
            tipos[0] = tbTipo1;
            tipos[1] = tbTipo2;
            tipos[2] = tbTipo3;
            tipos[3] = tbTipo4;
            tipos[4] = tbTipo5;
            tipos[5] = tbTipo6;
            String listaColumnas = "";
            for (int c=0; c<cantColumnas; c++)
            {
                if (c == 0)
                {
                    listaColumnas += columnas[c].Text + " " + tipos[c].Text + " PRIMARY KEY, ";
                    continue;
                }
                if (c == cantColumnas - 1)
                    listaColumnas += columnas[c].Text + " " + tipos[c].Text;
                else
                    listaColumnas += columnas[c].Text + " " + tipos[c].Text + ", ";
            }
            return listaColumnas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tablas tablas = new Tablas();
            tablas.Show();
            this.Hide();
        }
    }
}
