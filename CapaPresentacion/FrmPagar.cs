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

            double Dolares = 0;
            double Debito =0;
            double PagoMovil = 0;
            double Transferencia = 0;
            double Visa = 0;
            double Master = 0;
            double Efectivo = 0;
            double Vuelto = 0;
            

            if (!(this.txtDolar.Text == ""))
            {
                Dolares = Convert.ToDouble(this.txtDolar.Text);
            }
            if (!(this.txtDebito.Text == ""))
            {
               Debito = Convert.ToDouble(this.txtDebito.Text);
            }
            if (!(this.txtPagoMovil.Text == ""))
            {
                PagoMovil = Convert.ToDouble(this.txtPagoMovil.Text);
            }
            if (!(this.txtTransferencia.Text == ""))
            {
                Transferencia = Convert.ToDouble(this.txtTransferencia.Text);
            }
            if (!(this.txtVisa.Text == ""))
            {
                Visa = Convert.ToDouble(this.txtVisa.Text);
            }
            if (!(this.txtMaster.Text == ""))
            {
                Master = Convert.ToDouble(this.txtMaster.Text);
            }
            if (!(this.txtEfectivo.Text == ""))
            {
                Efectivo = Convert.ToDouble(this.txtEfectivo.Text);
            }
            if (!(this.txtVuelto.Text == ""))
            {
                Vuelto = Convert.ToDouble(this.txtVuelto.Text);
            }

            this.lbldolares.Text = string.Format("{0:0.00}" ,(TotalDolares - Dolares -(Debito / PrecioDolar) - (PagoMovil / PrecioDolar) - (Transferencia / PrecioDolar) - (Visa / PrecioDolar) - (Master / PrecioDolar) - (Efectivo / PrecioDolar)+(Vuelto / PrecioDolar)));
            this.lblBolivares.Text = string.Format("{0:0,0.00}", (TotalBolivares - (Dolares*PrecioDolar)- Debito - PagoMovil - Transferencia - Visa - Master - Efectivo + Vuelto));
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string rpta = "";
            string rpta2 = "";
            string rpta3 = "";
            string rpta4 = "";
            string rpta5 = "";

            try
            {
                if (Convert.ToDouble(this.lblBolivares.Text) > 0)
                {
                    MessageBox.Show("Debe Ingresar el Monto Completo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    double Dolares = 0;
                    double Debito = 0;
                    double PagoMovil = 0;
                    double Transferencia = 0;
                    double Visa = 0;
                    double Master = 0;
                    double Efectivo = 0;
                    double Vueltobs = 0;


                    if (!(this.txtDolar.Text == ""))
                    {
                        Dolares = Convert.ToDouble(this.txtDolar.Text);
                    }
                    if (!(this.txtDebito.Text == ""))
                    {
                        Debito = Convert.ToDouble(this.txtDebito.Text);
                    }
                    if (!(this.txtPagoMovil.Text == ""))
                    {
                        PagoMovil = Convert.ToDouble(this.txtPagoMovil.Text);
                    }
                    if (!(this.txtTransferencia.Text == ""))
                    {
                        Transferencia = Convert.ToDouble(this.txtTransferencia.Text);
                    }
                    if (!(this.txtVisa.Text == ""))
                    {
                        Visa = Convert.ToDouble(this.txtVisa.Text);
                    }
                    if (!(this.txtMaster.Text == ""))
                    {
                        Master = Convert.ToDouble(this.txtMaster.Text);
                    }
                    if (!(this.txtEfectivo.Text == ""))
                    {
                        Efectivo = Convert.ToDouble(this.txtEfectivo.Text);
                    }
                    if (!(this.txtVuelto.Text == ""))
                    {
                        Vueltobs = Convert.ToDouble(this.txtVuelto.Text);
                    }

                    DateTime hoy = DateTime.Now;
                    string fecha = hoy.ToString("d");


                

                    FrmVentas nom = new FrmVentas();

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

                    rpta = NPagos.Insertar(Convert.ToInt32(this.lblIdv.Text), fecha, Dolares, Debito, PagoMovil, Transferencia,
                        Visa, Master, Efectivo, Vueltobs);


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
            //MessageBox.Show(rpta);
            //MessageBox.Show(rpta2);
            //MessageBox.Show(rpta3);
            //MessageBox.Show(rpta4);
            //MessageBox.Show(rpta5);
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
    }
}
