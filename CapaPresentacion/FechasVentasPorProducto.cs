using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FechasVentasPorProducto : Form
    {
        public FechasVentasPorProducto()
        {
            InitializeComponent();
        }

        private void FechasVentasPorProducto_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmVentaPorProductoReport frm = new FrmVentaPorProductoReport();
            frm.Codigo = this.txtCodigo.Text;
            frm.Fecha1 = this.dtpDesde.Value;
            frm.Fecha2 = this.dtpHasta.Value;

            frm.ShowDialog();
        }
    }
}
