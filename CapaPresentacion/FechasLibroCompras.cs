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
    public partial class FechasLibroCompras : Form
    {
        public FechasLibroCompras()
        {
            InitializeComponent();
        }

        private void FechasLibroCompras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmLibroCompras frm = new FrmLibroCompras();
            frm.Fecha1 = this.dtpDesde.Value;
            frm.Fecha2 = this.dtpHasta.Value;

            frm.ShowDialog();
        }
    }
}
