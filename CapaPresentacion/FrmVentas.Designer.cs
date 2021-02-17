namespace CapaPresentacion
{
    partial class FrmVentas
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
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalproductos = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.labeloijof = new System.Windows.Forms.Label();
            this.labeldasda = new System.Windows.Forms.Label();
            this.lblExentoBolivares = new System.Windows.Forms.Label();
            this.lblTotalBolivares = new System.Windows.Forms.Label();
            this.labeloidjsf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDolares = new System.Windows.Forms.Label();
            this.lblExentoDolares = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipodePersona = new System.Windows.Forms.ComboBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.lblSubTotalDolar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSubTotalBolivares = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIvaDolar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIvaBolivares = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkFactura = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataListado.Location = new System.Drawing.Point(58, 185);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(995, 362);
            this.dataListado.TabIndex = 14;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 98;
            // 
            // lblTotalproductos
            // 
            this.lblTotalproductos.AutoSize = true;
            this.lblTotalproductos.Location = new System.Drawing.Point(779, 157);
            this.lblTotalproductos.Name = "lblTotalproductos";
            this.lblTotalproductos.Size = new System.Drawing.Size(51, 20);
            this.lblTotalproductos.TabIndex = 13;
            this.lblTotalproductos.Text = "label3";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(74, 156);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(111, 24);
            this.chkEliminar.TabIndex = 12;
            this.chkEliminar.Text = "Seleccionar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 26);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(376, 154);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(203, 26);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(703, 153);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 26);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(585, 153);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(952, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 41);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeloijof
            // 
            this.labeloijof.AutoSize = true;
            this.labeloijof.Location = new System.Drawing.Point(570, 604);
            this.labeloijof.Name = "labeloijof";
            this.labeloijof.Size = new System.Drawing.Size(86, 20);
            this.labeloijof.TabIndex = 22;
            this.labeloijof.Text = "Exento Bs:";
            // 
            // labeldasda
            // 
            this.labeldasda.AutoSize = true;
            this.labeldasda.Location = new System.Drawing.Point(792, 605);
            this.labeldasda.Name = "labeldasda";
            this.labeldasda.Size = new System.Drawing.Size(71, 20);
            this.labeldasda.TabIndex = 23;
            this.labeldasda.Text = "Total Bs:";
            // 
            // lblExentoBolivares
            // 
            this.lblExentoBolivares.AutoSize = true;
            this.lblExentoBolivares.Location = new System.Drawing.Point(649, 604);
            this.lblExentoBolivares.Name = "lblExentoBolivares";
            this.lblExentoBolivares.Size = new System.Drawing.Size(51, 20);
            this.lblExentoBolivares.TabIndex = 24;
            this.lblExentoBolivares.Text = "label3";
            // 
            // lblTotalBolivares
            // 
            this.lblTotalBolivares.AutoSize = true;
            this.lblTotalBolivares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBolivares.Location = new System.Drawing.Point(857, 602);
            this.lblTotalBolivares.Name = "lblTotalBolivares";
            this.lblTotalBolivares.Size = new System.Drawing.Size(76, 25);
            this.lblTotalBolivares.TabIndex = 25;
            this.lblTotalBolivares.Text = "label3";
            // 
            // labeloidjsf
            // 
            this.labeloidjsf.AutoSize = true;
            this.labeloidjsf.Location = new System.Drawing.Point(792, 565);
            this.labeloidjsf.Name = "labeloidjsf";
            this.labeloidjsf.Size = new System.Drawing.Size(61, 20);
            this.labeloidjsf.TabIndex = 26;
            this.labeloidjsf.Text = "Total $:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Exento $:";
            // 
            // lblTotalDolares
            // 
            this.lblTotalDolares.AutoSize = true;
            this.lblTotalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDolares.Location = new System.Drawing.Point(857, 562);
            this.lblTotalDolares.Name = "lblTotalDolares";
            this.lblTotalDolares.Size = new System.Drawing.Size(76, 25);
            this.lblTotalDolares.TabIndex = 33;
            this.lblTotalDolares.Text = "label3";
            // 
            // lblExentoDolares
            // 
            this.lblExentoDolares.AutoSize = true;
            this.lblExentoDolares.Location = new System.Drawing.Point(649, 565);
            this.lblExentoDolares.Name = "lblExentoDolares";
            this.lblExentoDolares.Size = new System.Drawing.Size(51, 20);
            this.lblExentoDolares.TabIndex = 34;
            this.lblExentoDolares.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 26);
            this.txtNombre.TabIndex = 36;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(335, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(299, 26);
            this.txtDireccion.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(259, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(504, 32);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(130, 26);
            this.txtTelefono.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(423, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Teléfono:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(145, 80);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(108, 26);
            this.txtCedula.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(21, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "CI o RIF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipodePersona);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(390, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 125);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // cbTipodePersona
            // 
            this.cbTipodePersona.FormattingEnabled = true;
            this.cbTipodePersona.Items.AddRange(new object[] {
            "V-",
            "J-",
            "G-",
            "E-",
            "P-"});
            this.cbTipodePersona.Location = new System.Drawing.Point(95, 78);
            this.cbTipodePersona.Name = "cbTipodePersona";
            this.cbTipodePersona.Size = new System.Drawing.Size(43, 28);
            this.cbTipodePersona.TabIndex = 45;
            // 
            // btnNotas
            // 
            this.btnNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.Location = new System.Drawing.Point(217, 39);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(139, 76);
            this.btnNotas.TabIndex = 46;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(58, 39);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(139, 76);
            this.btnFactura.TabIndex = 47;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // lblSubTotalDolar
            // 
            this.lblSubTotalDolar.AutoSize = true;
            this.lblSubTotalDolar.Location = new System.Drawing.Point(226, 566);
            this.lblSubTotalDolar.Name = "lblSubTotalDolar";
            this.lblSubTotalDolar.Size = new System.Drawing.Size(51, 20);
            this.lblSubTotalDolar.TabIndex = 51;
            this.lblSubTotalDolar.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Sub Total $:";
            // 
            // lblSubTotalBolivares
            // 
            this.lblSubTotalBolivares.AutoSize = true;
            this.lblSubTotalBolivares.Location = new System.Drawing.Point(226, 605);
            this.lblSubTotalBolivares.Name = "lblSubTotalBolivares";
            this.lblSubTotalBolivares.Size = new System.Drawing.Size(51, 20);
            this.lblSubTotalBolivares.TabIndex = 49;
            this.lblSubTotalBolivares.Text = "label3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Sub Total Bs:";
            // 
            // lblIvaDolar
            // 
            this.lblIvaDolar.AutoSize = true;
            this.lblIvaDolar.Location = new System.Drawing.Point(443, 565);
            this.lblIvaDolar.Name = "lblIvaDolar";
            this.lblIvaDolar.Size = new System.Drawing.Size(51, 20);
            this.lblIvaDolar.TabIndex = 55;
            this.lblIvaDolar.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "IVA $:";
            // 
            // lblIvaBolivares
            // 
            this.lblIvaBolivares.AutoSize = true;
            this.lblIvaBolivares.Location = new System.Drawing.Point(443, 604);
            this.lblIvaBolivares.Name = "lblIvaBolivares";
            this.lblIvaBolivares.Size = new System.Drawing.Size(51, 20);
            this.lblIvaBolivares.TabIndex = 53;
            this.lblIvaBolivares.Text = "label3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 604);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "IVA Bs:";
            // 
            // chkFactura
            // 
            this.chkFactura.AutoSize = true;
            this.chkFactura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkFactura.Location = new System.Drawing.Point(74, 9);
            this.chkFactura.Name = "chkFactura";
            this.chkFactura.Size = new System.Drawing.Size(83, 24);
            this.chkFactura.TabIndex = 56;
            this.chkFactura.Text = "Factura";
            this.chkFactura.UseVisualStyleBackColor = true;
            this.chkFactura.CheckedChanged += new System.EventHandler(this.chkFactura_CheckedChanged);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 662);
            this.Controls.Add(this.chkFactura);
            this.Controls.Add(this.lblIvaDolar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIvaBolivares);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSubTotalDolar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSubTotalBolivares);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExentoDolares);
            this.Controls.Add(this.lblTotalDolares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeloidjsf);
            this.Controls.Add(this.lblTotalBolivares);
            this.Controls.Add(this.lblExentoBolivares);
            this.Controls.Add(this.labeldasda);
            this.Controls.Add(this.labeloijof);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.lblTotalproductos);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVentas";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label lblTotalproductos;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labeloijof;
        private System.Windows.Forms.Label labeldasda;
        private System.Windows.Forms.Label labeloidjsf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExentoDolares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Label lblSubTotalDolar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIvaDolar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Button btnNotas;
        protected System.Windows.Forms.CheckBox chkFactura;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.ComboBox cbTipodePersona;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.Label lblTotalDolares;
        protected System.Windows.Forms.Label lblExentoBolivares;
        protected System.Windows.Forms.Label lblTotalBolivares;
        protected System.Windows.Forms.Label lblSubTotalBolivares;
        protected System.Windows.Forms.Label lblIvaBolivares;
        private System.Windows.Forms.DataGridView dataListado;
    }
}