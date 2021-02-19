namespace CapaPresentacion
{
    partial class frmMermaReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMerma = new CapaPresentacion.dsMerma();
            this.spMermaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMermaTableAdapter = new CapaPresentacion.dsMermaTableAdapters.spMermaTableAdapter();
            this.spMerma_por_TipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMerma_por_TipoTableAdapter = new CapaPresentacion.dsMermaTableAdapters.spMerma_por_TipoTableAdapter();
            this.spMermaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMermaTotalTableAdapter = new CapaPresentacion.dsMermaTableAdapters.spMermaTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsMerma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMermaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMerma_por_TipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMermaTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MermaDetalle";
            reportDataSource1.Value = this.spMermaBindingSource;
            reportDataSource2.Name = "MermaPorTipo";
            reportDataSource2.Value = this.spMerma_por_TipoBindingSource;
            reportDataSource3.Name = "MermaTotal";
            reportDataSource3.Value = this.spMermaTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptMerma.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsMerma
            // 
            this.dsMerma.DataSetName = "dsMerma";
            this.dsMerma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spMermaBindingSource
            // 
            this.spMermaBindingSource.DataMember = "spMerma";
            this.spMermaBindingSource.DataSource = this.dsMerma;
            // 
            // spMermaTableAdapter
            // 
            this.spMermaTableAdapter.ClearBeforeFill = true;
            // 
            // spMerma_por_TipoBindingSource
            // 
            this.spMerma_por_TipoBindingSource.DataMember = "spMerma_por_Tipo";
            this.spMerma_por_TipoBindingSource.DataSource = this.dsMerma;
            // 
            // spMerma_por_TipoTableAdapter
            // 
            this.spMerma_por_TipoTableAdapter.ClearBeforeFill = true;
            // 
            // spMermaTotalBindingSource
            // 
            this.spMermaTotalBindingSource.DataMember = "spMermaTotal";
            this.spMermaTotalBindingSource.DataSource = this.dsMerma;
            // 
            // spMermaTotalTableAdapter
            // 
            this.spMermaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // frmMermaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMermaReport";
            this.Text = "Reporte de Merma";
            this.Load += new System.EventHandler(this.frmMermaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMerma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMermaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMerma_por_TipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMermaTotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMermaBindingSource;
        private dsMerma dsMerma;
        private System.Windows.Forms.BindingSource spMerma_por_TipoBindingSource;
        private System.Windows.Forms.BindingSource spMermaTotalBindingSource;
        private dsMermaTableAdapters.spMermaTableAdapter spMermaTableAdapter;
        private dsMermaTableAdapters.spMerma_por_TipoTableAdapter spMerma_por_TipoTableAdapter;
        private dsMermaTableAdapters.spMermaTotalTableAdapter spMermaTotalTableAdapter;
    }
}