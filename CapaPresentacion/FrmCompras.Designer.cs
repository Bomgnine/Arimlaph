namespace CapaPresentacion
{
    partial class FrmCompras
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
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
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
            this.dataListado.Location = new System.Drawing.Point(16, 205);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(864, 282);
            this.dataListado.TabIndex = 80;
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
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(46, 178);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(84, 24);
            this.chkEliminar.TabIndex = 78;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(197, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 26);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(500, 176);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 26);
            this.txtBuscar.TabIndex = 76;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Buscar por Razón Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "N° Operación:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Enabled = false;
            this.txtOperacion.Location = new System.Drawing.Point(155, 16);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(100, 26);
            this.txtOperacion.TabIndex = 82;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(187, 69);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(133, 26);
            this.txtFecha.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Fecha de Factura:";
            // 
            // txtRif
            // 
            this.txtRif.Location = new System.Drawing.Point(154, 101);
            this.txtRif.Name = "txtRif";
            this.txtRif.Size = new System.Drawing.Size(166, 26);
            this.txtRif.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "RIF:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 26);
            this.txtNombre.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Razón Social:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(442, 69);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(137, 26);
            this.txtFactura.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "N° de Factura:";
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(442, 101);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(137, 26);
            this.txtControl.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "N° Control:";
            // 
            // txtMaquina
            // 
            this.txtMaquina.Location = new System.Drawing.Point(459, 133);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(120, 26);
            this.txtMaquina.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Id Máquina Fiscal:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(718, 69);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(133, 26);
            this.txtBase.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 95;
            this.label9.Text = "Base Imponible:";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(681, 101);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(170, 26);
            this.txtImpuesto.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = "Impuesto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(661, 133);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(190, 26);
            this.txtTotal.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(595, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 99;
            this.label11.Text = "Total";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(707, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 32);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(347, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 32);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(511, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 32);
            this.btnEditar.TabIndex = 103;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(681, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 33);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 515);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompras";
            this.Text = "Registro de Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}