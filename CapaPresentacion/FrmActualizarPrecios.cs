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
    public partial class FrmActualizarPrecios : Form
    {
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Precios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Precios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public FrmActualizarPrecios()
        {
            InitializeComponent();
        }

        private void FrmActualizarPrecios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.txtPrecioD.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtPrecioD.Text == string.Empty)
                {
                    MensajeError("Debe Ingesar el Precio");
                }
                else
                {
                    rpta = NActualizarPrecios.ActualizarPrecios(Convert.ToDouble(this.txtPrecioD.Text.Trim()));


                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se han actualizado los Precios en Bolívares");




                        FrmActualizarPrecios.ActiveForm.Close();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
