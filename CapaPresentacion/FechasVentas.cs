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
    public partial class FechasVentas : Form
    {
        public FechasVentas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmVentasReport frm = new FrmVentasReport();
            frm.Fecha1 = this.dtpDesde.Value;
            frm.Fecha2 = this.dtpHasta.Value;

            frm.ShowDialog();
        }

        private void FechasVentas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.dtpDesde.Value = Convert.ToDateTime(DateTime.Now.ToString("d"));
            this.dtpHasta.Value = Convert.ToDateTime(DateTime.Now.ToString("d"));
        }
    }
}
