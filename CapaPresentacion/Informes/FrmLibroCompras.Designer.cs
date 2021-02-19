namespace CapaPresentacion
{
    partial class FrmLibroCompras
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
            this.dsCompras = new CapaPresentacion.dsCompras();
            this.spinforme_comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spinforme_comprasTableAdapter = new CapaPresentacion.dsComprasTableAdapters.spinforme_comprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LibroCompras";
            reportDataSource1.Value = this.spinforme_comprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptLibroCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1086, 648);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCompras
            // 
            this.dsCompras.DataSetName = "dsCompras";
            this.dsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spinforme_comprasBindingSource
            // 
            this.spinforme_comprasBindingSource.DataMember = "spinforme_compras";
            this.spinforme_comprasBindingSource.DataSource = this.dsCompras;
            // 
            // spinforme_comprasTableAdapter
            // 
            this.spinforme_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLibroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 648);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLibroCompras";
            this.Text = "Libro de Compras";
            this.Load += new System.EventHandler(this.FrmLibroCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spinforme_comprasBindingSource;
        private dsCompras dsCompras;
        private dsComprasTableAdapters.spinforme_comprasTableAdapter spinforme_comprasTableAdapter;
    }
}