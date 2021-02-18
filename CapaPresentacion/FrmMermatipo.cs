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
    public partial class FrmMermatipo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmMermatipo()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Tipo de Merma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Tipo de Merma", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
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
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NMermatipo.Mostrar();
            this.OcultarColumnas();
            this.dataListado.Columns[1].Width = 40;
            this.dataListado.Columns[2].Width = 200;
            this.dataListado.Columns[3].Width = 400;            
        }
        private void FrmMermatipo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Debe Ingesar el Nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NMermatipo.Insertar(this.txtNombre.Text, this.txtDescripcion.Text);
                    }
                    else
                    {
                        rpta = NMermatipo.Editar(Convert.ToInt32(this.txtCodigo.Text), this.txtNombre.Text, this.txtDescripcion.Text);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Tipo de Merma agregado correctamente");
                        }
                        else
                        {
                            this.MensajeOk("Se ha editado el Tipo de Merma");
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
        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero el Tipo de Merma a editar");
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se eliminaran los Tipos de Merma seleccionados", "Tipo de Merma", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NMermatipo.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el tipo de merma");
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
    }
}
