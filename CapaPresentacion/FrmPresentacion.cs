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
    public partial class FrmPresentacion : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;


        public FrmPresentacion()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Presentación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Presentación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtSiglas.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdpresentacion.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.txtIdpresentacion.ReadOnly = !valor;
            this.txtSiglas.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
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

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NPresentacion.Mostrar();
            this.OcultarColumnas();
            this.dataListado.Columns[2].Width = 100;
            this.dataListado.Columns[3].Width = 400;
            this.lblTotal.Text = "Presentaciones: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.dataListado.DataSource = NPresentacion.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Presentaciones: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
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
            this.txtSiglas.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtSiglas.Text == string.Empty)
                {
                    MensajeError("Debe Ingesar la Sigla");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NPresentacion.Insertar(this.txtSiglas.Text.ToUpper(), this.txtDescripcion.Text);
                    }
                    else
                    {
                        rpta = NPresentacion.Editar(Convert.ToInt32(this.txtIdpresentacion.Text), this.txtSiglas.Text.ToUpper(), this.txtDescripcion.Text);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Presentación agregada correctamente");
                        }
                        else
                        {
                            this.MensajeOk("Se ha editado la presentación");
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdpresentacion.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero la presentación a editar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsEditar = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se eliminaran las presentaciones seleccionadas", "Presentacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NPresentacion.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó la presentación");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chkEliminar.Checked = false;
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtIdpresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);
            this.txtSiglas.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sigla"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

        }
    }
}
