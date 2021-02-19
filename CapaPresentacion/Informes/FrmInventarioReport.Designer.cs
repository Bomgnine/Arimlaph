namespace CapaPresentacion
{
    partial class FrmInventarioReport
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
            this.dsInventario = new CapaPresentacion.dsInventario();
            this.spinventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spinventarioTableAdapter = new CapaPresentacion.dsInventarioTableAdapters.spinventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Inventario";
            reportDataSource1.Value = this.spinventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsInventario
            // 
            this.dsInventario.DataSetName = "dsInventario";
            this.dsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spinventarioBindingSource
            // 
            this.spinventarioBindingSource.DataMember = "spinventario";
            this.spinventarioBindingSource.DataSource = this.dsInventario;
            // 
            // spinventarioTableAdapter
            // 
            this.spinventarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInventarioReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInventarioReport";
            this.Text = "Reporte de Inventario";
            this.Load += new System.EventHandler(this.FrmInventarioReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spinventarioBindingSource;
        private dsInventario dsInventario;
        private dsInventarioTableAdapters.spinventarioTableAdapter spinventarioTableAdapter;
    }
}