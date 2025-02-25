using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CasaDomotica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        void login()
        {
            if(txtContraseña.Text == "1234" & txtUsuario.Text == "Admin")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            txtUsuario.Focus();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


            string password = txtContraseña.Text;  // Contraseña
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
               { login(); }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') {
                txtContraseña.Focus();
                login();
                txtContraseña.Focus();
            }
        }
    }
}
