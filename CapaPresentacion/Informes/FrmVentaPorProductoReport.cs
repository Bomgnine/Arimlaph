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
    public partial class FrmVentaPorProductoReport : Form
    {
        public FrmVentaPorProductoReport()
        {
            InitializeComponent();
        }
        private DateTime _Fecha1;
        private DateTime _Fecha2;
        private string _Codigo;
        public DateTime Fecha1 { get => _Fecha1; set => _Fecha1 = value; }
        public DateTime Fecha2 { get => _Fecha2; set => _Fecha2 = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }

        private void FrmVentaPorProductoReport_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsVentasPorProducto.spventas_totales_por_producto' Puede moverla o quitarla según sea necesario.
                this.spventas_totales_por_productoTableAdapter.Fill(this.dsVentasPorProducto.spventas_totales_por_producto, Codigo, Fecha1, Fecha2);
                // TODO: esta línea de código carga datos en la tabla 'dsVentasPorProducto.spventas_detallada_por_producto' Puede moverla o quitarla según sea necesario.
                this.spventas_detallada_por_productoTableAdapter.Fill(this.dsVentasPorProducto.spventas_detallada_por_producto, Codigo, Fecha1, Fecha2);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
