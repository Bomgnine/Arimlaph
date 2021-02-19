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
    public partial class FrmLibroCompras : Form
    {
        public FrmLibroCompras()
        {
            InitializeComponent();
        }
        private DateTime _Fecha1;
        private DateTime _Fecha2;

        public DateTime Fecha1 { get => _Fecha1; set => _Fecha1 = value; }
        public DateTime Fecha2 { get => _Fecha2; set => _Fecha2 = value; }

        private void FrmLibroCompras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsCompras.spinforme_compras' Puede moverla o quitarla según sea necesario.
                this.spinforme_comprasTableAdapter.Fill(this.dsCompras.spinforme_compras, Fecha1, Fecha2);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
