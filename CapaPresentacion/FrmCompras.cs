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
    public partial class FrmCompras : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.txtOperacion.Text = string.Empty;
            this.txtFecha.Text = string.Empty;
            this.txtRif.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtFactura.Text = string.Empty;
            this.txtControl.Text = string.Empty;
            this.txtMaquina.Text = string.Empty;
            this.txtBase.Text = string.Empty;
            this.txtImpuesto.Text = string.Empty;
            this.txtTotal.Text = string.Empty;
            this.txtBuscar.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.txtFecha.ReadOnly = !valor;
            this.txtRif.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtFactura.ReadOnly = !valor;
            this.txtControl.ReadOnly = !valor;
            this.txtMaquina.ReadOnly = !valor;
            this.txtBase.ReadOnly = !valor;
            this.txtImpuesto.ReadOnly = !valor;
            this.txtTotal.ReadOnly = !valor;
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void OcultarColumna()
        {
            this.dataListado.Columns[0].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NCompras.Mostrar();            
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCompras.Buscar(this.txtBuscar.Text);      
        }
        public FrmCompras()
        {
            InitializeComponent();           
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.OcultarColumna();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtOperacion.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero la factura a editar");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsEditar = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.OcultarColumna();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtFecha.Text == string.Empty || this.txtRif.Text == string.Empty ||
                    this.txtNombre.Text == string.Empty || this.txtTotal.Text == string.Empty)
                {
                    MensajeError("Debe ingresar fecha de la factura, RIF, Razón social y total en los formatos correctos ");
                }
                else
                {
                    DateTime fecha1 = Convert.ToDateTime(this.txtFecha.Text);
                    string fecha = fecha1.ToString("d");

                    double baseI = 0;
                    double impuesto = 0;
                    double total = 0;

                    if (!(this.txtBase.Text == ""))
                    {
                        baseI = Convert.ToDouble(this.txtBase.Text);
                    }
                    else
                    {
                        baseI = 0;
                    }
                    if (!(this.txtImpuesto.Text == ""))
                    {
                        impuesto = Convert.ToDouble(this.txtImpuesto.Text);
                    }
                    else
                    {
                        impuesto = 0;
                    }
                    if (!(this.txtTotal.Text == ""))
                    {
                        total = Convert.ToDouble(this.txtTotal.Text);
                    }
                    else
                    {
                        total = 0;
                    }

                    if (this.IsNuevo)
                    {
                        MessageBox.Show("nuevo");                  
                        rpta = NCompras.Insertar(fecha, this.txtNombre.Text, this.txtRif.Text, this.txtFactura.Text,
                            this.txtControl.Text, this.txtMaquina.Text, baseI, impuesto, total);
                    }
                    else
                    {
                        MessageBox.Show("Editar");
                        rpta = NCompras.Editar(Convert.ToInt32(this.txtOperacion.Text), fecha, this.txtNombre.Text, this.txtRif.Text, this.txtFactura.Text,
                             this.txtControl.Text, this.txtMaquina.Text, baseI, impuesto, total);                        
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Factura guardada correctamente");
                        }
                        else
                        {
                            this.MensajeOk("Se ha editado la factura");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                Opcion = MessageBox.Show("Se eliminaran las Facturas seleccionadas", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NCompras.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó la compra");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chkEliminar.Checked = false;
                    this.OcultarColumna();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }
        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtOperacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nOperacion"].Value);
            this.txtFecha.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fechaFactura"].Value);
            this.txtRif.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["rif"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtFactura.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nFactura"].Value);
            this.txtControl.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nControl"].Value);
            this.txtMaquina.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nMaquinaFiscal"].Value);
            this.txtBase.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["base"].Value);
            this.txtImpuesto.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["impuesto"].Value);
            this.txtTotal.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
        }
    }
}
