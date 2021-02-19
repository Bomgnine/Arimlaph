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
    public partial class FechasGanancias : Form
    {
        public FechasGanancias()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmGanancias rpt = new frmGanancias();
            rpt.Fecha1 = this.dtpDesde.Value;
            rpt.Fecha2 = this.dtpHasta.Value;
            rpt.Show();
        }

        private void FechasGanancias_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
