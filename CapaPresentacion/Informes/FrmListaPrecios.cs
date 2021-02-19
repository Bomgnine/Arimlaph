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
    public partial class FrmListaPrecios : Form
    {
        public FrmListaPrecios()
        {
            InitializeComponent();
        }

        private void FrmListaPrecios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsListaPrecios.spLista_Precios' Puede moverla o quitarla según sea necesario.
                this.spLista_PreciosTableAdapter.Fill(this.dsListaPrecios.spLista_Precios);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}
