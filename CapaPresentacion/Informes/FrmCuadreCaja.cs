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
    public partial class FrmCuadreCaja : Form
    {
        public FrmCuadreCaja()
        {
            InitializeComponent();
        }

        private void FrmCuadreCaja_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                string hoy = DateTime.Now.ToString("d");
                DateTime fecha = Convert.ToDateTime(hoy);

                // TODO: esta línea de código carga datos en la tabla 'dsCuadreCaja.spcuadrar_caja' Puede moverla o quitarla según sea necesario.
                this.spcuadrar_cajaTableAdapter.Fill(this.dsCuadreCaja.spcuadrar_caja, fecha);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
