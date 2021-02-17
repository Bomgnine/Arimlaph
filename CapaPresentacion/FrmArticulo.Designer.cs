namespace CapaPresentacion
{
    partial class FrmArticulo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdcategoria = new System.Windows.Forms.ComboBox();
            this.cbIdpresentacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkExcento = new System.Windows.Forms.CheckBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPcompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPventa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPVPbs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(362, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(362, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(362, 97);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(362, 61);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 30);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 205);
            this.txtDescripcion.MaxLength = 256;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(338, 23);
            this.txtDescripcion.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 139);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 26);
            this.txtNombre.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre P:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 98;
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.Enabled = false;
            this.txtIdarticulo.Location = new System.Drawing.Point(114, 41);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(136, 26);
            this.txtIdarticulo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Código P:";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataListado.Location = new System.Drawing.Point(46, 373);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(706, 182);
            this.dataListado.TabIndex = 43;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellDoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(281, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "label3";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(76, 346);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(84, 24);
            this.chkEliminar.TabIndex = 41;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(352, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 26);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(144, 316);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 26);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre P:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Productos";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 107);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 26);
            this.txtCodigo.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Código Barra:";
            // 
            // pxImagen
            // 
            this.pxImagen.BackgroundImage = global::CapaPresentacion.Properties.Resources.file;
            this.pxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxImagen.Location = new System.Drawing.Point(6, 34);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(235, 188);
            this.pxImagen.TabIndex = 56;
            this.pxImagen.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(21, 228);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 30);
            this.btnCargar.TabIndex = 57;
            this.btnCargar.Text = "Agregar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(134, 228);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Descartar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.pxImagen);
            this.groupBox1.Location = new System.Drawing.Point(479, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 264);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto del Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Categoria:";
            // 
            // cbIdcategoria
            // 
            this.cbIdcategoria.FormattingEnabled = true;
            this.cbIdcategoria.Location = new System.Drawing.Point(114, 73);
            this.cbIdcategoria.Name = "cbIdcategoria";
            this.cbIdcategoria.Size = new System.Drawing.Size(236, 28);
            this.cbIdcategoria.TabIndex = 61;
            // 
            // cbIdpresentacion
            // 
            this.cbIdpresentacion.FormattingEnabled = true;
            this.cbIdpresentacion.Location = new System.Drawing.Point(114, 171);
            this.cbIdpresentacion.Name = "cbIdpresentacion";
            this.cbIdpresentacion.Size = new System.Drawing.Size(236, 28);
            this.cbIdpresentacion.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Presentación:";
            // 
            // chkExcento
            // 
            this.chkExcento.AutoSize = true;
            this.chkExcento.Location = new System.Drawing.Point(264, 40);
            this.chkExcento.Name = "chkExcento";
            this.chkExcento.Size = new System.Drawing.Size(78, 24);
            this.chkExcento.TabIndex = 66;
            this.chkExcento.Text = "Exento";
            this.chkExcento.UseVisualStyleBackColor = true;
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(42, 274);
            this.txtInventario.MaxLength = 50;
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(104, 26);
            this.txtInventario.TabIndex = 68;
            this.txtInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInventario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Inventario";
            // 
            // txtPcompra
            // 
            this.txtPcompra.Location = new System.Drawing.Point(186, 274);
            this.txtPcompra.MaxLength = 50;
            this.txtPcompra.Name = "txtPcompra";
            this.txtPcompra.Size = new System.Drawing.Size(120, 26);
            this.txtPcompra.TabIndex = 70;
            this.txtPcompra.Text = "0,00";
            this.txtPcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Precio Compra $";
            // 
            // txtPventa
            // 
            this.txtPventa.Location = new System.Drawing.Point(339, 274);
            this.txtPventa.MaxLength = 50;
            this.txtPventa.Name = "txtPventa";
            this.txtPventa.Size = new System.Drawing.Size(118, 26);
            this.txtPventa.TabIndex = 72;
            this.txtPventa.Text = "0,00";
            this.txtPventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Precio Venta $";
            // 
            // txtPVPbs
            // 
            this.txtPVPbs.Enabled = false;
            this.txtPVPbs.Location = new System.Drawing.Point(512, 331);
            this.txtPVPbs.MaxLength = 50;
            this.txtPVPbs.Name = "txtPVPbs";
            this.txtPVPbs.Size = new System.Drawing.Size(208, 26);
            this.txtPVPbs.TabIndex = 74;
            this.txtPVPbs.Text = "0,00";
            this.txtPVPbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "PVPbs";
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 580);
            this.Controls.Add(this.txtPVPbs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPventa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPcompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkExcento);
            this.Controls.Add(this.cbIdpresentacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbIdcategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdarticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmArticulo";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdpresentacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkExcento;
        private System.Windows.Forms.ComboBox cbIdcategoria;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPcompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPventa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPVPbs;
        private System.Windows.Forms.Label label12;
    }
}