using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lName.Text = ConnectionManager.usuario;
        }

        private void bConnections_Click(object sender, EventArgs e)
        {
            Conexiones conexiones = new Conexiones();
            conexiones.Show();
            this.Hide();
        }

        private void bTablas_Click(object sender, EventArgs e)
        {
            Tablas tablas = new Tablas();
            tablas.Show();
            this.Hide();
        }

        private void bIndices_Click(object sender, EventArgs e)
        {
            Indices indices = new Indices();
            indices.Show();
            this.Hide();
        }

        private void bProcedimientos_Click(object sender, EventArgs e)
        {
            Procedimientos procedimientos = new Procedimientos();
            procedimientos.Show();
            this.Hide();
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            Triggers tr = new Triggers();
            tr.Show();
            this.Hide();
        }

        private void bVistas_Click(object sender, EventArgs e)
        {
            Views views = new Views();
            views.Show();
            this.Hide();
        }
    }
}
