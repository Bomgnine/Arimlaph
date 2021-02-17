namespace CapaPresentacion
{
    partial class FrmInventario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPventa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPcompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventarioActual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(565, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 72);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(190, 101);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 26);
            this.txtNombre.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(190, 56);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(203, 26);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Código:";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(33, 291);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(667, 154);
            this.dataListado.TabIndex = 26;
            this.dataListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inventario";
            // 
            // txtPventa
            // 
            this.txtPventa.Location = new System.Drawing.Point(526, 254);
            this.txtPventa.MaxLength = 50;
            this.txtPventa.Name = "txtPventa";
            this.txtPventa.Size = new System.Drawing.Size(118, 26);
            this.txtPventa.TabIndex = 78;
            this.txtPventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "Precio Venta $";
            // 
            // txtPcompra
            // 
            this.txtPcompra.Location = new System.Drawing.Point(373, 254);
            this.txtPcompra.MaxLength = 50;
            this.txtPcompra.Name = "txtPcompra";
            this.txtPcompra.Size = new System.Drawing.Size(120, 26);
            this.txtPcompra.TabIndex = 76;
            this.txtPcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "Precio Compra $";
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(229, 254);
            this.txtInventario.MaxLength = 50;
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(118, 26);
            this.txtInventario.TabIndex = 74;
            this.txtInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "Agregar";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(190, 144);
            this.txtDescripcion.MaxLength = 256;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(317, 60);
            this.txtDescripcion.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Descripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(565, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 72);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "Limpiar  Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Inventario Actual";
            // 
            // txtInventarioActual
            // 
            this.txtInventarioActual.Enabled = false;
            this.txtInventarioActual.Location = new System.Drawing.Point(79, 254);
            this.txtInventarioActual.Name = "txtInventarioActual";
            this.txtInventarioActual.Size = new System.Drawing.Size(124, 26);
            this.txtInventarioActual.TabIndex = 84;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInventarioActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPventa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPcompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPventa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPcompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInventarioActual;
    }
}