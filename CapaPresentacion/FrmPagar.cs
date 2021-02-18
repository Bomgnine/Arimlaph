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
    public partial class FrmPagar : Form
    {
        double Dolares = 0;
        double Debito = 0;
        double PagoMovil = 0;
        double Transferencia = 0;
        double Visa = 0;
        double Master = 0;
        double Efectivo = 0;
        double Vuelto = 0;
        public FrmPagar()
        {
            InitializeComponent();
        }
        private void FrmPagar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.lblIdv.Text = NAuxventas.Idv();
            this.lblPreciodelDolar.Text = string.Format("{0:0,0.00}", (Convert.ToDouble(this.lblTotalBolivaresPagar.Text)/Convert.ToDouble(this.lblTotalDolaresPagar.Text)));
            this.lbldolares.Text = string.Format("{0:0.00}", Convert.ToDouble(this.lblTotalDolaresPagar.Text));
            this.lblBolivares.Text = string.Format("{0:0,0.00}", Convert.ToDouble(this.lblTotalBolivaresPagar.Text));
            frmNotaDeEntrega NumeroIDV = new frmNotaDeEntrega();
            NumeroIDV.IDV = Convert.ToInt32(this.lblIdv.Text);
        }
        private void Calculos()
        {
            double TotalBolivares = Convert.ToDouble(this.lblTotalBolivaresPagar.Text);
            double TotalDolares = Convert.ToDouble(this.lblTotalDolaresPagar.Text);
            double PrecioDolar = Convert.ToDouble(this.lblPreciodelDolar.Text);
            this.lbldolares.Text = string.Format("{0:0.00}" ,(TotalDolares - Dolares -(Debito / PrecioDolar) - (PagoMovil / PrecioDolar) - (Transferencia / PrecioDolar) - (Visa / PrecioDolar) - (Master / PrecioDolar) - (Efectivo / PrecioDolar)+(Vuelto / PrecioDolar)));
            this.lblBolivares.Text = string.Format("{0:0,0.00}", (TotalBolivares - (Dolares*PrecioDolar)- Debito - PagoMovil - Transferencia - Visa - Master - Efectivo + Vuelto));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string rpta, rpta2, rpta3, rpta4, rpta5;
            try
            {
                if (Convert.ToDouble(this.lblBolivares.Text) > 0)
                {
                    MessageBox.Show("Debe Ingresar el Monto Completo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DateTime hoy = DateTime.Now;
                    string fecha = hoy.ToString("d");
  
                    string nombre = this.lblNombre.Text;
                    string cedula = this.lblTipo.Text + this.lblCedula.Text;
                    string telefono = this.lbltelefono.Text;
                    string direccion = this.lblDirección.Text;
                    double TTBs = Convert.ToDouble(this.lblTotalBolivaresPagar.Text);
                    double TTD = Convert.ToDouble(this.lblTotalDolaresPagar.Text);
                                        
                    double subtotalbs = 0 ; //Convert.ToDouble(this.lblSubtotalbolivares.Text)
                    double ivabs = 0 ; //Convert.ToDouble(this.lblIvaBolivares.Text)
                    double exentobs = 0 ; //Convert.ToDouble(this.lblexento.Text)

                    if(!(this.lblSubtotalbolivares.Text == ""))
                    {
                        subtotalbs = Convert.ToDouble(this.lblSubtotalbolivares.Text);
                    }
                    if (!(this.lblIvaBolivares.Text == ""))
                    {
                        ivabs = Convert.ToDouble(this.lblIvaBolivares.Text);
                    }
                    if (!(this.lblexento.Text == ""))
                    {
                        exentobs = Convert.ToDouble(this.lblexento.Text);
                    }

                    rpta2 = NFacturas.Insertar(0,0, fecha, nombre, cedula, telefono, direccion, subtotalbs , ivabs , exentobs, TTBs, TTD);
                    rpta3 = NAuxventas.ActualizarInventario();
                    rpta4 = NPagos.InsertarVenta(Convert.ToInt32(this.lblIdv.Text), fecha);
                    rpta = NPagos.Insertar(Convert.ToInt32(this.lblIdv.Text), fecha, Dolares, Debito, PagoMovil, Transferencia, Visa, Master, Efectivo, Vuelto);
                    MessageBox.Show("Venta realizada - Imprimir nota", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rpta5 = NAuxventas.Borrar();
                    NAuxventas.Mostrar();
                    Close();
                    frmNotaDeEntrega NumeroIDV = new frmNotaDeEntrega();
                    NumeroIDV.IDV = Convert.ToInt32(this.lblIdv.Text);
                    NumeroIDV.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                rpta3 = ex.Message;
                rpta5=  ex.Message;  
            }
        }
        private void txtDolar_Leave(object sender, EventArgs e)
        {
            this.Calculos();
        }
        private void txtDebito_Leave(object sender, EventArgs e)
        {
            this.Calculos();
        }
        private void txtPagoMovil_Leave(object sender, EventArgs e)
        {
            this.Calculos();
        }
        private void txtTransferencia_Leave(object sender, EventArgs e)
        {
            this.Calculos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtDolar.Text == ""))
            {
                Dolares = Convert.ToDouble(this.txtDolar.Text);
            }
            else
            {
                Dolares = 0;
            }
        }
        private void txtDebito_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtDebito.Text == ""))
            {
                Debito = Convert.ToDouble(this.txtDebito.Text);
            }
            else
            {
                Debito = 0;
            }
        }
        private void txtPagoMovil_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtPagoMovil.Text == ""))
            {
                PagoMovil = Convert.ToDouble(this.txtPagoMovil.Text);
            }
            else
            {
                PagoMovil = 0;
            }
        }
        private void txtTransferencia_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtTransferencia.Text == ""))
            {
                Transferencia = Convert.ToDouble(this.txtTransferencia.Text);
            }
            else
            {
                Transferencia = 0;
            }
        }
        private void txtVisa_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtVisa.Text == ""))
            {
                Visa = Convert.ToDouble(this.txtVisa.Text);
            }
            else
            {
                Visa = 0;
            }
        }
        private void txtMaster_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtMaster.Text == ""))
            {
                Master = Convert.ToDouble(this.txtMaster.Text);
            }
            else
            {
                Master = 0;
            }
        }
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtEfectivo.Text == ""))
            {
                Efectivo = Convert.ToDouble(this.txtEfectivo.Text);
            }
            else
            {
                Efectivo = 0;
            }
        }
        private void txtVuelto_TextChanged(object sender, EventArgs e)
        {
            if (!(this.txtVuelto.Text == ""))
            {
                Vuelto = Convert.ToDouble(this.txtVuelto.Text);
            }
            else
            {
                Vuelto = 0;
            }
        }
    }
}
