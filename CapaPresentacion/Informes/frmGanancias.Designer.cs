namespace CapaPresentacion
{
    partial class frmGanancias
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
            this.dsGanancias = new CapaPresentacion.dsGanancias();
            this.spreporte_gananciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_gananciasTableAdapter = new CapaPresentacion.dsGananciasTableAdapters.spreporte_gananciasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_gananciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Ganancias";
            reportDataSource1.Value = this.spreporte_gananciasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptGanancias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(837, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsGanancias
            // 
            this.dsGanancias.DataSetName = "dsGanancias";
            this.dsGanancias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_gananciasBindingSource
            // 
            this.spreporte_gananciasBindingSource.DataMember = "spreporte_ganancias";
            this.spreporte_gananciasBindingSource.DataSource = this.dsGanancias;
            // 
            // spreporte_gananciasTableAdapter
            // 
            this.spreporte_gananciasTableAdapter.ClearBeforeFill = true;
            // 
            // frmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGanancias";
            this.Text = "Ganancias";
            this.Load += new System.EventHandler(this.frmGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_gananciasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_gananciasBindingSource;
        private dsGanancias dsGanancias;
        private dsGananciasTableAdapters.spreporte_gananciasTableAdapter spreporte_gananciasTableAdapter;
    }
}