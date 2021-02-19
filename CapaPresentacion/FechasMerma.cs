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
    public partial class FechasMerma : Form
    {
        public FechasMerma()
        {
            InitializeComponent();
        }

        private void FechasMerma_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmMermaReport frm = new frmMermaReport();
            frm.Fecha1 = this.dtpDesde.Value;
            frm.Fecha2 = this.dtpHasta.Value;

            frm.ShowDialog();
        }
    }
}
