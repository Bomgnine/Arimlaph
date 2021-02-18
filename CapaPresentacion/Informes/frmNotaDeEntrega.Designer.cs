namespace CapaPresentacion
{
    partial class frmNotaDeEntrega
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
            this.spNotas_entregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNotasDeEntrega = new CapaPresentacion.dsNotasDeEntrega();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spNotas_entregaTableAdapter = new CapaPresentacion.dsNotasDeEntregaTableAdapters.spNotas_entregaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spNotas_entregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasDeEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // spNotas_entregaBindingSource
            // 
            this.spNotas_entregaBindingSource.DataMember = "spNotas_entrega";
            this.spNotas_entregaBindingSource.DataSource = this.dsNotasDeEntrega;
            // 
            // dsNotasDeEntrega
            // 
            this.dsNotasDeEntrega.DataSetName = "dsNotasDeEntrega";
            this.dsNotasDeEntrega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NotasdeEntrega";
            reportDataSource1.Value = this.spNotas_entregaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.rptNotaDeEntrega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(837, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // spNotas_entregaTableAdapter
            // 
            this.spNotas_entregaTableAdapter.ClearBeforeFill = true;
            // 
            // frmNotaDeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 741);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNotaDeEntrega";
            this.Text = "Nota de Entrega";
            this.Load += new System.EventHandler(this.frmNotaDeEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spNotas_entregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasDeEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spNotas_entregaBindingSource;
        private dsNotasDeEntrega dsNotasDeEntrega;
        private dsNotasDeEntregaTableAdapters.spNotas_entregaTableAdapter spNotas_entregaTableAdapter;
    }
}