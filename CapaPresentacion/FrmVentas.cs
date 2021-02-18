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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[2].Visible = false;
        }
        private void Botones()
        {
            if (this.chkFactura.Checked)
            {
                this.btnNotas.Enabled = false;
                this.btnFactura.Enabled = true;
            }
            else
            {
                this.btnNotas.Enabled = true;
                this.btnFactura.Enabled = false;
            }
        }
        private void LimpiarEtiquetas()
        {
            this.lblTotalBolivares.Text = string.Empty;
            this.lblExentoBolivares.Text = string.Empty;
            this.lblSubTotalBolivares.Text = string.Empty;
            this.lblIvaBolivares.Text = string.Empty;
            this.lblTotalDolares.Text = string.Empty;
            this.lblExentoDolares.Text = string.Empty;
            this.lblSubTotalDolar.Text = string.Empty;
            this.lblIvaDolar.Text = string.Empty;
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
            this.Calculos();
        }     
        private void Calculos()
        {
            double IVA = 1.16;

            var totalproductos = NAuxventas.Mostrar().Compute("SUM(cantidad)", "");
            this.lblTotalproductos.Text = "Total Productos: " + Convert.ToString(totalproductos);

            if (!((Convert.ToString(totalproductos))==""))
            {

                ////////////////////////sub total, iva, total exento, Total //////////////////////////

                //////////////////////     total en bolívares        //////////////

                var totalbs = NAuxventas.Mostrar().Compute("SUM(ImporteBs)", "");
                this.lblTotalBolivares.Text= string.Format("{0:0,0.00}", totalbs);

                //////////////////////       total en dólares       //////////////

                var totaldolar = NAuxventas.Mostrar().Compute("SUM(Importe$)", "");
                this.lblTotalDolares.Text = string.Format("{0:0.00}", totaldolar);

                //////////////////////       exento ,  sub total  e  IVA    //////////////

                var exentobs = NAuxventas.Mostrar().Compute("SUM(ImporteBs)", "nombre like '*(E)'");    // exento en bolivares
                var subtotalBolivares = NAuxventas.Mostrar().Compute("SUM(ImporteBs)", "not nombre like '*(E)'"); // sub total en bolivares

                var exentodolar = NAuxventas.Mostrar().Compute("SUM(Importe$)", "nombre like '*(E)'");  // exento en dólares
                var subtotaldolar = NAuxventas.Mostrar().Compute("SUM(Importe$)", "not nombre like '*(E)'"); // sub total en dólares

                if (!((Convert.ToString(subtotalBolivares)) == ""))
                {
                    this.lblSubTotalBolivares.Text = string.Format("{0:0,0.00}", Convert.ToDouble(subtotalBolivares) / IVA);
                    this.lblSubTotalDolar.Text = string.Format("{0:0.00}", Convert.ToDouble(subtotaldolar) / IVA   );

                    this.lblIvaBolivares.Text = string.Format("{0:0,0.00}", Convert.ToDouble(subtotalBolivares)-(Convert.ToDouble(subtotalBolivares) / IVA));
                    this.lblIvaDolar.Text = string.Format("{0:0.00}", Convert.ToDouble(subtotaldolar) - (Convert.ToDouble(subtotaldolar) / IVA));
                }

                if (!((Convert.ToString(exentobs)) == ""))
                {
                    this.lblExentoBolivares.Text = string.Format("{0:0,0.00}", exentobs);
                    this.lblExentoDolares.Text = string.Format("{0:0.00}", exentodolar);
                }            
            }
        }
        private void FrmVentas_Load(object sender, EventArgs e)
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
                this.LimpiarEtiquetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Mostrar();
            CenterToScreen();
            this.btnEliminar.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.txtId.Enabled = false;
            this.txtId.Visible = false;
            this.LimpiarEtiquetas();
            this.Botones();
        }
        // insertar producto cuando se escanea el código de barras
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        // para eliminar productos seleccionados
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
                Opcion = MessageBox.Show("Se eliminaran los artículos seleccionados", "Categorias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                    this.LimpiarEtiquetas();
                    this.Calculos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Procedimiento para editar las cantidades
        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
            this.txtCantidad.Enabled = true;
            this.txtCantidad.Text = "0";
            this.txtCantidad.Focus();
        }
        public void ActualizarData()
        {
            this.Mostrar();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    string rpta = "";

                    if (this.txtCantidad.Text == string.Empty)
                    {
                        this.txtCantidad.Text = "0";
                    }
                    rpta = NAuxventas.Editar(Convert.ToInt32(this.txtId.Text), Convert.ToInt32(this.txtCantidad.Text.Trim()));

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Cantidad agregada");
                    }
                    this.txtId.Text = string.Empty;
                    this.txtCantidad.Text = string.Empty;
                    this.txtCantidad.Enabled = false;
                    this.txtCodigo.Focus();
                }
                this.Mostrar();
            }
            catch(Exception ex)
            {
                this.MensajeError("Debe ingresar una cantidad válida" + ex.Message + ex.StackTrace);
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            this.txtId.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtCantidad.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
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
                this.LimpiarEtiquetas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void chkFactura_CheckedChanged(object sender, EventArgs e)
        {
            this.Botones();
        }
        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (this.lblTotalBolivares.Text == "")
            {
                MensajeError("Debe ingresar productos");
                this.txtCodigo.Focus();
            }
            else
            {
                if (this.txtNombre.Text == "")
                {
                    this.txtNombre.Text = "Consumidor Final";
                }
                if (this.txtCedula.Text == "")
                {
                    this.txtCedula.Text = "00000000-0";
                }       
                FrmPagar form = new FrmPagar();   
                form.lblTotalBolivaresPagar.Text = this.lblTotalBolivares.Text;
                form.lblTotalDolaresPagar.Text = this.lblTotalDolares.Text;
                form.lblexento.Text = this.lblExentoBolivares.Text;
                form.lblIvaBolivares.Text = this.lblIvaBolivares.Text;
                form.lblSubtotalbolivares.Text = this.lblSubTotalBolivares.Text;
                form.lblNombre.Text = this.txtNombre.Text;
                form.lblTipo.Text = this.cbTipodePersona.Text;
                form.lblCedula.Text = this.txtCedula.Text;
                form.lbltelefono.Text = this.txtTelefono.Text;
                form.lblDirección.Text = this.txtDireccion.Text;
                form.ShowDialog();                
            }
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (this.lblTotalBolivares.Text == "")
            {
                MensajeError("Debe ingresar productos");
                this.txtCodigo.Focus();
            }
            else
            {
                if (this.txtNombre.Text == "" || this.txtCedula.Text == "")
                {
                    MensajeError("Debe ingresar Nombre o Razón Social y Cédula o RIF");
                }
                else
                {
                    FrmPagar form = new FrmPagar();
                    form.lblTotalBolivaresPagar.Text = this.lblTotalBolivares.Text;
                    form.lblTotalDolaresPagar.Text = this.lblTotalDolares.Text;
                    form.lblexento.Text = this.lblExentoBolivares.Text;
                    form.lblIvaBolivares.Text = this.lblIvaBolivares.Text;
                    form.lblSubtotalbolivares.Text = this.lblSubTotalBolivares.Text;
                    form.lblNombre.Text = this.txtNombre.Text;
                    form.lblTipo.Text = this.cbTipodePersona.Text;
                    form.lblCedula.Text = this.txtCedula.Text;
                    form.lbltelefono.Text = this.txtTelefono.Text;
                    form.lblDirección.Text = this.txtDireccion.Text;
                    form.ShowDialog();
                }
            }
        }
    }
}
