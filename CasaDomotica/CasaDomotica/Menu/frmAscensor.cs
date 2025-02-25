using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDomotica.Menu
{
    public partial class frmAscensor : Form
    {
        public frmAscensor()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            btnBajar.IconColor = Color.Green;
            btnSubir.IconColor = Color.Red;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            btnSubir.IconColor = Color.Green;
            btnBajar.IconColor = Color.Red;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
