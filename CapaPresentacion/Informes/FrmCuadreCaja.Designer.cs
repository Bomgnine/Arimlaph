namespace CapaPresentacion
{
    partial class FrmCuadreCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCuadreCaja = new CapaPresentacion.dsCuadreCaja();
            this.spcuadrar_cajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spcuadrar_cajaTableAdapter = new CapaPresentacion.dsCuadreCajaTableAdapters.spcuadrar_cajaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuadreCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcuadrar_cajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CuadreCaja";
            reportDataSource1.Value = this.spcuadrar_cajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptCuadreCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(837, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCuadreCaja
            // 
            this.dsCuadreCaja.DataSetName = "dsCuadreCaja";
            this.dsCuadreCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spcuadrar_cajaBindingSource
            // 
            this.spcuadrar_cajaBindingSource.DataMember = "spcuadrar_caja";
            this.spcuadrar_cajaBindingSource.DataSource = this.dsCuadreCaja;
            // 
            // spcuadrar_cajaTableAdapter
            // 
            this.spcuadrar_cajaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCuadreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCuadreCaja";
            this.Text = "Cuadre de Caja";
            this.Load += new System.EventHandler(this.FrmCuadreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCuadreCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcuadrar_cajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spcuadrar_cajaBindingSource;
        private dsCuadreCaja dsCuadreCaja;
        private dsCuadreCajaTableAdapters.spcuadrar_cajaTableAdapter spcuadrar_cajaTableAdapter;
    }
}