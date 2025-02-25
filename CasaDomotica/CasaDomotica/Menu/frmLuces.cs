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
    public partial class frmLuces : Form
    {
        public frmLuces()
        {
            InitializeComponent();
        }

        public void LuzEstado()
        {
            notifyIcon1.BalloonTipText = "Luz de " + label1.Text + " encendida"; 
            notifyIcon1.BalloonTipTitle = "Notificación"; // Título de la notificación (modifícalo si es necesario)
            notifyIcon1.ShowBalloonTip(4000); // Muestra la notificación durante 4 segundos (4000 milisegundos)

        }

        private void frmLuces_Load(object sender, EventArgs e)
        {
            LuzEstado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tswGaraje_CheckedChanged(object sender, EventArgs e)
        {
            LuzEstado();
        }

        private void tswBano_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
