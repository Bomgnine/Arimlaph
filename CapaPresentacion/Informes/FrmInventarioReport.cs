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
    public partial class FrmInventarioReport : Form
    {
        public FrmInventarioReport()
        {
            InitializeComponent();
        }

        private void FrmInventarioReport_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsInventario.spinventario' Puede moverla o quitarla según sea necesario.
                this.spinventarioTableAdapter.Fill(this.dsInventario.spinventario);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
