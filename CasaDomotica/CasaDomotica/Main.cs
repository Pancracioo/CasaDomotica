using CasaDomotica.FrmMensajes;
using CasaDomotica.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CasaDomotica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;

            }

        }
        frmAscensor frmAscensor = new frmAscensor();
        CasaDomotica.Menu.frmLuces frmLuces = new Menu.frmLuces();

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
          
            AbrirForm(frmAscensor);
        }
        /*
        private void AbrirForm(Form form)
        {
            if (this.topMain.Controls.Count > 1) { this.topMain.Controls.RemoveAt(0); }
            Form form1 = form as Form;
            form1.TopLevel = false;
            //form1.Dock = DockStyle.Fill;
            topMain.BringToFront();
            this.topMain.Controls.Add(form1);
            this.topMain.Tag = form1;
            form1.Show();

        }
        */
        private void AbrirForm(Form form)
        {
            try
            {
                // Crear una instancia del formulario
                Form form1 = form as Form;
                // Verifica si ya existe un formulario similar en el panel
                foreach (System.Windows.Controls.Control control in topMain.Controls)
                {
                    if (control.GetType() == form1.GetType())
                    {
                        form1.BringToFront();
                        return;
                    }
                }
                form1.TopLevel = false;
                // form1.Dock = DockStyle.Fill; 
                topMain.Controls.Add(form1);
                form1.Show();
            }
            catch {  }
                 
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            /*
            frmControlLuces frmControlLuces = new frmControlLuces();
            frmControlLuces.ShowDialog();
            */
            AbrirForm(frmLuces);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            
        }

        private void btnOtros_Click(object sender, EventArgs e)
        { 

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
