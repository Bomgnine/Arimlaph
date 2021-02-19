namespace CapaPresentacion
{
    partial class FrmFacturasEmitidas
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
            this.spinforme_facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFacturas = new CapaPresentacion.dsFacturas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spinforme_facturasTableAdapter = new CapaPresentacion.dsFacturasTableAdapters.spinforme_facturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // spinforme_facturasBindingSource
            // 
            this.spinforme_facturasBindingSource.DataMember = "spinforme_facturas";
            this.spinforme_facturasBindingSource.DataSource = this.dsFacturas;
            // 
            // dsFacturas
            // 
            this.dsFacturas.DataSetName = "dsFacturas";
            this.dsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FacturasEmitidas";
            reportDataSource1.Value = this.spinforme_facturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptFacturasEmitidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1086, 648);
            this.reportViewer1.TabIndex = 0;
            // 
            // spinforme_facturasTableAdapter
            // 
            this.spinforme_facturasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFacturasEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 648);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFacturasEmitidas";
            this.Text = "Informe de Facturas Emitidas";
            this.Load += new System.EventHandler(this.FrmFacturasEmitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spinforme_facturasBindingSource;
        private dsFacturas dsFacturas;
        private dsFacturasTableAdapters.spinforme_facturasTableAdapter spinforme_facturasTableAdapter;
    }
}