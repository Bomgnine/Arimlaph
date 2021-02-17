namespace CapaPresentacion
{
    partial class FrmActualizarPrecios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioD = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio del Dolar";
            // 
            // txtPrecioD
            // 
            this.txtPrecioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioD.Location = new System.Drawing.Point(38, 63);
            this.txtPrecioD.MaxLength = 21;
            this.txtPrecioD.Name = "txtPrecioD";
            this.txtPrecioD.Size = new System.Drawing.Size(263, 31);
            this.txtPrecioD.TabIndex = 1;
            this.txtPrecioD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(79, 112);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(177, 67);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Precios";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 212);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPrecioD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmActualizarPrecios";
            this.Text = "Actualizar Precio del Dolar";
            this.Load += new System.EventHandler(this.FrmActualizarPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtPrecioD;
    }
}