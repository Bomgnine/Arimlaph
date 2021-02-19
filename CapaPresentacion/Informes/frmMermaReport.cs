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
    public partial class frmMermaReport : Form
    {
        public frmMermaReport()
        {
            InitializeComponent();
        }
        private DateTime _Fecha1;
        private DateTime _Fecha2;

        public DateTime Fecha1 { get => _Fecha1; set => _Fecha1 = value; }
        public DateTime Fecha2 { get => _Fecha2; set => _Fecha2 = value; }

        private void frmMermaReport_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsMerma.spMerma' Puede moverla o quitarla según sea necesario.
                this.spMermaTableAdapter.Fill(this.dsMerma.spMerma, Fecha1, Fecha2);
                // TODO: esta línea de código carga datos en la tabla 'dsMerma.spMerma_por_Tipo' Puede moverla o quitarla según sea necesario.
                this.spMerma_por_TipoTableAdapter.Fill(this.dsMerma.spMerma_por_Tipo, Fecha1, Fecha2);
                // TODO: esta línea de código carga datos en la tabla 'dsMerma.spMermaTotal' Puede moverla o quitarla según sea necesario.
                this.spMermaTotalTableAdapter.Fill(this.dsMerma.spMermaTotal, Fecha1, Fecha2);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
