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
    public partial class FrmArticulo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmArticulo()
        {
            InitializeComponent();

            this.LlenarComboCategoria();
            this.LlenarComboPresentacion();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtIdarticulo.Text = string.Empty;
            this.cbIdcategoria.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.cbIdpresentacion.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.file;
            this.txtInventario.Text = string.Empty;
            this.txtPcompra.Text = string.Empty;
            this.txtPventa.Text = string.Empty;
            
        }
        private void Habilitar(bool valor)
        {
            this.txtIdarticulo.ReadOnly = !valor;
            this.cbIdcategoria.Enabled = valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.cbIdpresentacion.Enabled = valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.btnCargar.Enabled = valor;
            this.btnLimpiar.Enabled = valor;
            this.txtInventario.ReadOnly = !valor;
            this.txtPcompra.ReadOnly = !valor;
            this.txtPventa.ReadOnly = !valor;
            this.txtPVPbs.ReadOnly = !valor;

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
                this.chkExcento.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.chkExcento.Enabled = false;
            }
        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[10].Visible = false;
            this.dataListado.Columns[12].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            this.dataListado.Columns[2].Width = 50;
            this.dataListado.Columns[3].Width = 200;
            this.dataListado.Columns[4].Width = 300;

            this.lblTotal.Text = "Productos registrados: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.dataListado.DataSource = NArticulo.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Productos registrados: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void LlenarComboPresentacion()
        {
            cbIdpresentacion.DataSource = NPresentacion.Mostrar();
            cbIdpresentacion.ValueMember = "idpresentacion";
            cbIdpresentacion.DisplayMember = "sigla";
        }
        private void LlenarComboCategoria()
        {
            cbIdcategoria.DataSource = NCategoria.Mostrar();
            cbIdcategoria.ValueMember = "idcategoria";
            cbIdcategoria.DisplayMember = "nombre";
        }


        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(dialog.FileName);

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.file;
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
            this.txtCodigo.Focus();

            this.txtInventario.Text = "0";
            this.txtPcompra.Text = "0,00";
            this.txtPventa.Text = "0,00";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.cbIdcategoria.Text == string.Empty || this.txtCodigo.Text == string.Empty ||
                    this.txtNombre.Text == string.Empty || this.cbIdpresentacion.Text == string.Empty
                    || this.txtPventa.Text == string.Empty)
                {
                    MensajeError("Debe llenar los campor Categoria, Código Barra, Nombre P, Presentación y Precio venta $");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen = ms.GetBuffer();


                    if (this.IsNuevo)
                    {
                        string producto = "";

                        if (chkExcento.Checked)
                        {
                            producto = this.txtNombre.Text + " (E)";
                        }
                        else
                        {
                            producto = this.txtNombre.Text;
                        }
                            rpta = NArticulo.Insertar(this.txtCodigo.Text.Trim(), producto.ToUpper(), 
                            this.txtDescripcion.Text, imagen, Convert.ToInt32(this.cbIdcategoria.SelectedValue),
                            Convert.ToInt32(this.cbIdpresentacion.SelectedValue), Convert.ToInt32(this.txtInventario.Text),
                            Convert.ToDouble(this.txtPcompra.Text), Convert.ToDouble(this.txtPventa.Text), 
                            Convert.ToDouble(this.txtPVPbs.Text));
                    }
                    else
                    {
                        string producto = "";

                        if (chkExcento.Checked)
                        {
                            producto = this.txtNombre.Text + " (E)";
                        }
                        else
                        {
                            producto = this.txtNombre.Text;
                        }

                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtIdarticulo.Text),
                            this.txtCodigo.Text.Trim(), producto.ToUpper().Trim(),
                            this.txtDescripcion.Text, imagen, Convert.ToInt32(this.cbIdcategoria.SelectedValue),
                            Convert.ToInt32(this.cbIdpresentacion.SelectedValue), Convert.ToInt32(this.txtInventario.Text),
                            Convert.ToDouble(this.txtPcompra.Text), Convert.ToDouble(this.txtPventa.Text),
                            Convert.ToDouble(this.txtPVPbs.Text));
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Producto agregado correctamente");
                        }
                        else
                        {
                            this.MensajeOk("Se ha editado el producto");
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
                    this.chkExcento.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdarticulo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);

                if (this.txtPVPbs.Text.Equals(""))
                {
                    this.txtPVPbs.Text = "0,00";
                }
                if (this.txtInventario.Text.Equals(""))
                {
                    this.txtInventario.Text = "0";
                }
                if (this.txtPcompra.Text.Equals(""))
                {
                    this.txtPcompra.Text = "0,00";
                }
                if (this.txtPventa.Text.Equals(""))
                {
                    this.txtPventa.Text = "0,00";
                }

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el producto a editar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsEditar = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.chkExcento.Checked = false;
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
            this.txtIdarticulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idarticulo"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigo"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            this.txtInventario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["inventario"].Value);
            this.txtPcompra.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Pcompra$"].Value);
            this.txtPventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Pventa$"].Value);
            this.txtPVPbs.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["PVPbs"].Value);

            byte[] imagenbuffer = (byte[]) this.dataListado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenbuffer);

            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.cbIdcategoria.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.cbIdpresentacion.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);

            if (this.txtPVPbs.Text.Equals(""))
            {
                this.txtPVPbs.Text = "0,00";
            }
            if (this.txtInventario.Text.Equals(""))
            {
                this.txtInventario.Text = "0";
            }
            if (this.txtPcompra.Text.Equals(""))
            {
                this.txtPcompra.Text = "0,00";
            }
            if (this.txtPventa.Text.Equals(""))
            {
                this.txtPventa.Text = "0,00";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se eliminaran los productos seleccionadas", "Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el artículo");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
