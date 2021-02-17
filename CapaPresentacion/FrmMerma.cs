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
    public partial class FrmMerma : Form
    {
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Merma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Merma", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public FrmMerma()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[2].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[8].Visible = false;
            this.dataListado.Columns[9].Visible = false;
        }
        public void Mostrar()
        {
            this.dataListado.DataSource = NAuxventas.Mostrar();
            this.OcultarColumnas();
            this.dataListado.Columns[3].Width = 75;
            this.dataListado.Columns[4].Width = 300;
            this.dataListado.Columns[5].Width = 75;
            this.dataListado.Columns[7].Width = 150;
            this.dataListado.Columns[9].Width = 150;
        }
        private void LlenarComboMermatipo()
        {
            cbMermatipo.DataSource = NMermatipo.Mostrar();
            cbMermatipo.ValueMember = "id";
            cbMermatipo.DisplayMember = "tipo";
        }








        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string rpta = "";

                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (this.txtCodigo.Text == string.Empty)
                    {
                        this.MensajeError("Debe escanear un código o ingresar un código válido");
                    }
                    else
                    {
                        rpta = NAuxventas.Insertar(this.txtCodigo.Text.Trim());

                        if (!rpta.Equals("OK"))
                        {
                            this.MensajeError("Debe escanear un código o ingresar un código válido");
                        }
                    }
                    this.Mostrar();
                    this.txtCodigo.Text = string.Empty;
                    this.txtCodigo.Focus();

                    this.LlenarComboMermatipo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                rpta = NAuxventas.Borrar();

                if (rpta.Equals("OK"))
                {
                    MensajeOk("Se han eliminado los productos");
                }
                this.Mostrar();
                this.txtCodigo.Focus();
                


            }
            catch (Exception ex)
            {

            }
        }

        private void FrmMerma_Load(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                rpta = NAuxventas.Borrar();

                if (rpta.Equals("OK"))
                {
                    MensajeOk("Se han eliminado los productos");
                }
                this.Mostrar();
                this.txtCodigo.Focus();
                
            }
            catch (Exception ex)
            {
            }
            this.txtCodigo.Focus();
            this.Mostrar();
            CenterToScreen();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                rpta = NAuxventas.Borrar();

                if (rpta.Equals("OK"))
                {
                    MensajeOk("Se han eliminado los productos");
                }
                this.Mostrar();
                this.txtCodigo.Focus();
                


            }
            catch (Exception ex)
            {

            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;

            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se eliminaran los artículos seleccionados", "Merma", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NAuxventas.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el producto de la lista");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chkEliminar.Checked = false;
                    this.txtCodigo.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string rpta2 = "";

                if (this.cbMermatipo.Text == string.Empty)
                {
                    MensajeError("Debe Ingesar el articulo y seleccionar el tipo de merma");
                }
                else
                {
                    DateTime hoy = DateTime.Now;
                    string fecha = hoy.ToString("d");

                    string tipomerma = this.cbMermatipo.Text;

                    rpta = NMerma.Insertar(fecha, tipomerma);

                    rpta2 = NAuxventas.ActualizarInventario();

                    NAuxventas.Borrar();


                    if (rpta.Equals("OK"))
                    {
                        
                            this.MensajeOk("Se ha registrado la merma");
                 
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
