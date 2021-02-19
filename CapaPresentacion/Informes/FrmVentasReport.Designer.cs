namespace CapaPresentacion
{
    partial class FrmVentasReport
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
            this.dsVentas = new CapaPresentacion.dsVentas();
            this.sptotal_ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sptotal_ventasTableAdapter = new CapaPresentacion.dsVentasTableAdapters.sptotal_ventasTableAdapter();
            this.sptotal_ventas_descripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sptotal_ventas_descripcionTableAdapter = new CapaPresentacion.dsVentasTableAdapters.sptotal_ventas_descripcionTableAdapter();
            this.sptotal_ventas_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sptotal_ventas_DetalleTableAdapter = new CapaPresentacion.dsVentasTableAdapters.sptotal_ventas_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventas_descripcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventas_DetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VentaTotal";
            reportDataSource1.Value = this.sptotal_ventasBindingSource;
            reportDataSource2.Name = "VentaPorCategoría";
            reportDataSource2.Value = this.sptotal_ventas_descripcionBindingSource;
            reportDataSource3.Name = "VentaDetallada";
            reportDataSource3.Value = this.sptotal_ventas_DetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsVentas
            // 
            this.dsVentas.DataSetName = "dsVentas";
            this.dsVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sptotal_ventasBindingSource
            // 
            this.sptotal_ventasBindingSource.DataMember = "sptotal_ventas";
            this.sptotal_ventasBindingSource.DataSource = this.dsVentas;
            // 
            // sptotal_ventasTableAdapter
            // 
            this.sptotal_ventasTableAdapter.ClearBeforeFill = true;
            // 
            // sptotal_ventas_descripcionBindingSource
            // 
            this.sptotal_ventas_descripcionBindingSource.DataMember = "sptotal_ventas_descripcion";
            this.sptotal_ventas_descripcionBindingSource.DataSource = this.dsVentas;
            // 
            // sptotal_ventas_descripcionTableAdapter
            // 
            this.sptotal_ventas_descripcionTableAdapter.ClearBeforeFill = true;
            // 
            // sptotal_ventas_DetalleBindingSource
            // 
            this.sptotal_ventas_DetalleBindingSource.DataMember = "sptotal_ventas_Detalle";
            this.sptotal_ventas_DetalleBindingSource.DataSource = this.dsVentas;
            // 
            // sptotal_ventas_DetalleTableAdapter
            // 
            this.sptotal_ventas_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVentasReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVentasReport";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FrmVentasReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventas_descripcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptotal_ventas_DetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sptotal_ventasBindingSource;
        private dsVentas dsVentas;
        private System.Windows.Forms.BindingSource sptotal_ventas_descripcionBindingSource;
        private System.Windows.Forms.BindingSource sptotal_ventas_DetalleBindingSource;
        private dsVentasTableAdapters.sptotal_ventasTableAdapter sptotal_ventasTableAdapter;
        private dsVentasTableAdapters.sptotal_ventas_descripcionTableAdapter sptotal_ventas_descripcionTableAdapter;
        private dsVentasTableAdapters.sptotal_ventas_DetalleTableAdapter sptotal_ventas_DetalleTableAdapter;
    }
}