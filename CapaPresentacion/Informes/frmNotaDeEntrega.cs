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
    public partial class frmNotaDeEntrega : Form
    {
        private int _IDV;
        public int IDV { get => _IDV; set => _IDV = value; }
        public frmNotaDeEntrega()
        {
            InitializeComponent();
        }

        private void frmNotaDeEntrega_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                int idv = IDV;
                // TODO: esta línea de código carga datos en la tabla 'dsNotasDeEntrega.spNotas_entrega' Puede moverla o quitarla según sea necesario.
                this.spNotas_entregaTableAdapter.Fill(this.dsNotasDeEntrega.spNotas_entrega, idv);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
