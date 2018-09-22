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
    public partial class VerDDL : Form
    {
        String tabla;
        public VerDDL(String t)
        {
            InitializeComponent();
            tabla = t;
            DDLTabla();
        }

        private void VerDDL_Load(object sender, EventArgs e)
        {

        }

        private void DDLTabla()
        {
            String text = System.IO.File.ReadAllText(@"F:/DatabaseManager/DDLs/" + tabla + ".sql");
            tbFile.Text = text;
        }
    }
}
