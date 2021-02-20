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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnActualizarDolar_Click(object sender, EventArgs e)
        {
            FrmActualizarPrecios form = new FrmActualizarPrecios();
            form.ShowDialog();
        }

        private void btnCuadre_Click(object sender, EventArgs e)
        {
            FrmCuadreCaja Cuadre = new FrmCuadreCaja();
            Cuadre.ShowDialog();
        }

        private void btnInformeMerma_Click(object sender, EventArgs e)
        {
            FechasMerma frm = new FechasMerma();

            frm.ShowDialog();
        }

        private void btnInventarioInforme_Click(object sender, EventArgs e)
        {
            FrmInventarioReport frm = new FrmInventarioReport();

            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FechasVentas frm = new FechasVentas();

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();

            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCompras frm = new FrmCompras();

            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmFacturas frm = new FrmFacturas();

            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMerma frm = new FrmMerma();

            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMermatipo frm = new FrmMermatipo();

            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmPresentacion frm = new FrmPresentacion();

            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();

            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();

            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FechasFacturasEmitidas frm = new FechasFacturasEmitidas();

            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FechasVentasPorProducto frm = new FechasVentasPorProducto();

            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmListaPrecios frm = new FrmListaPrecios();

            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FechasGanancias frm = new FechasGanancias();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FechasLibroCompras frm = new FechasLibroCompras();
            frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }
    }
}
