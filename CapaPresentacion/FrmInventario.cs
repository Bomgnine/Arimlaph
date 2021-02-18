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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            this.dataListado.DataSource = NInventario.MostrarInventario();
            this.dataListado.Columns[1].Width = 200;
            this.dataListado.Columns[2].Visible = false;
            this.txtCodigo.Focus();
        }
        private void BuscarInventario()
        {            
            this.dataListado.DataSource = NInventario.BuscarInventario(this.txtCodigo.Text);
        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.txtCodigo.Focus();                      
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.BuscarInventario();
                this.txtInventario.Focus();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";               
                int suma, Iactual, Iagregar;

                if (this.txtInventarioActual.Text == "")
                {
                    Iactual = 0;
                }
                else
                {
                    Iactual = Convert.ToInt32(this.txtInventarioActual.Text);
                }

                if(this.txtInventario.Text == "")
                {
                    Iagregar = 0;
                }
                else
                {
                    Iagregar = Convert.ToInt32(this.txtInventario.Text);
                }

                suma = Iactual + Iagregar;

                rpta = NInventario.EditarInventario(this.txtCodigo.Text, suma,
                    Convert.ToDouble(this.txtPcompra.Text), Convert.ToDouble(this.txtPventa.Text));

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Inventario actualizado correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se actualizó el Inventario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.BuscarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            this.txtInventarioActual.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["inventario"].Value);
            this.txtPcompra.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Pcompra$"].Value);
            this.txtPventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Pventa$"].Value);
            this.txtInventario.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtInventarioActual.Text = string.Empty;
            this.txtInventario.Text = string.Empty;
            this.txtPcompra.Text = string.Empty;
            this.txtPventa.Text = string.Empty;
            this.txtCodigo.Focus();
            this.BuscarInventario();           
        }       
    }
}
