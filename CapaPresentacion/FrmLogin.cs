using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text == string.Empty || this.txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Usuario y Contraseña para iniciar seción", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
            else
            {
                string rpta = "";

                try
                {
                    rpta = NUsuarios.Login(this.txtUsuario.Text, this.txtContraseña.Text);

                    if (rpta == "Menu")
                    {
                        FrmMenu frm = new FrmMenu();
                        frm.Show();
                    }
                    else if(rpta == "Ventas")
                    {
                        FrmVentas frm = new FrmVentas();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña Incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.txtUsuario.Text = string.Empty;
                    this.txtContraseña.Text = string.Empty;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(rpta + ex.Message);
                }
            }
        }
    }
}
