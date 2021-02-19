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
    public partial class FrmVentasReport : Form
    {
        public FrmVentasReport()
        {
            InitializeComponent();
        }
        private DateTime _Fecha1;
        private DateTime _Fecha2;

        public DateTime Fecha1 { get => _Fecha1; set => _Fecha1 = value; }
        public DateTime Fecha2 { get => _Fecha2; set => _Fecha2 = value; }

        private void FrmVentasReport_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsVentas.sptotal_ventas' Puede moverla o quitarla según sea necesario.
                this.sptotal_ventasTableAdapter.Fill(this.dsVentas.sptotal_ventas, Fecha1, Fecha2);
                // TODO: esta línea de código carga datos en la tabla 'dsVentas.sptotal_ventas_descripcion' Puede moverla o quitarla según sea necesario.
                this.sptotal_ventas_descripcionTableAdapter.Fill(this.dsVentas.sptotal_ventas_descripcion, Fecha1, Fecha2);
                // TODO: esta línea de código carga datos en la tabla 'dsVentas.sptotal_ventas_Detalle' Puede moverla o quitarla según sea necesario.
                this.sptotal_ventas_DetalleTableAdapter.Fill(this.dsVentas.sptotal_ventas_Detalle, Fecha1, Fecha2);
            
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
