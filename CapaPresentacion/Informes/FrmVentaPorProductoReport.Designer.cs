namespace CapaPresentacion
{
    partial class FrmVentaPorProductoReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsVentasPorProducto = new CapaPresentacion.dsVentasPorProducto();
            this.spventas_totales_por_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spventas_totales_por_productoTableAdapter = new CapaPresentacion.dsVentasPorProductoTableAdapters.spventas_totales_por_productoTableAdapter();
            this.spventas_detallada_por_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spventas_detallada_por_productoTableAdapter = new CapaPresentacion.dsVentasPorProductoTableAdapters.spventas_detallada_por_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentasPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spventas_totales_por_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spventas_detallada_por_productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VentaTotalPorProducto";
            reportDataSource1.Value = this.spventas_totales_por_productoBindingSource;
            reportDataSource2.Name = "VentaDetalladaPorProducto";
            reportDataSource2.Value = this.spventas_detallada_por_productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptVentasPorProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsVentasPorProducto
            // 
            this.dsVentasPorProducto.DataSetName = "dsVentasPorProducto";
            this.dsVentasPorProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spventas_totales_por_productoBindingSource
            // 
            this.spventas_totales_por_productoBindingSource.DataMember = "spventas_totales_por_producto";
            this.spventas_totales_por_productoBindingSource.DataSource = this.dsVentasPorProducto;
            // 
            // spventas_totales_por_productoTableAdapter
            // 
            this.spventas_totales_por_productoTableAdapter.ClearBeforeFill = true;
            // 
            // spventas_detallada_por_productoBindingSource
            // 
            this.spventas_detallada_por_productoBindingSource.DataMember = "spventas_detallada_por_producto";
            this.spventas_detallada_por_productoBindingSource.DataSource = this.dsVentasPorProducto;
            // 
            // spventas_detallada_por_productoTableAdapter
            // 
            this.spventas_detallada_por_productoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVentaPorProductoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVentaPorProductoReport";
            this.Text = "Reporte de Ventas del Producto";
            this.Load += new System.EventHandler(this.FrmVentaPorProductoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVentasPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spventas_totales_por_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spventas_detallada_por_productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spventas_totales_por_productoBindingSource;
        private dsVentasPorProducto dsVentasPorProducto;
        private System.Windows.Forms.BindingSource spventas_detallada_por_productoBindingSource;
        private dsVentasPorProductoTableAdapters.spventas_totales_por_productoTableAdapter spventas_totales_por_productoTableAdapter;
        private dsVentasPorProductoTableAdapters.spventas_detallada_por_productoTableAdapter spventas_detallada_por_productoTableAdapter;
    }
}