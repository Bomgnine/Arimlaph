namespace CapaPresentacion
{
    partial class FrmPagar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagoMovil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTotalBolivaresPagar = new System.Windows.Forms.Label();
            this.lblTotalDolaresPagar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPreciodelDolar = new System.Windows.Forms.Label();
            this.lblBolivares = new System.Windows.Forms.Label();
            this.lbldolares = new System.Windows.Forms.Label();
            this.lblIdv = new System.Windows.Forms.Label();
            this.lblexento = new System.Windows.Forms.Label();
            this.lblIvaBolivares = new System.Windows.Forms.Label();
            this.lblSubtotalbolivares = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVuelto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEfectivo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVisa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTransferencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPagoMovil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDebito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDolar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de pago";
            // 
            // txtVuelto
            // 
            this.txtVuelto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVuelto.Location = new System.Drawing.Point(186, 313);
            this.txtVuelto.MaxLength = 20;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(191, 29);
            this.txtVuelto.TabIndex = 15;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVuelto.Leave += new System.EventHandler(this.txtTransferencia_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(53, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Vuelto bs:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEfectivo.Location = new System.Drawing.Point(186, 253);
            this.txtEfectivo.MaxLength = 20;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(191, 29);
            this.txtEfectivo.TabIndex = 13;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.Leave += new System.EventHandler(this.txtTransferencia_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(53, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Efectivo:";
            // 
            // txtMaster
            // 
            this.txtMaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaster.Location = new System.Drawing.Point(186, 218);
            this.txtMaster.MaxLength = 20;
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.Size = new System.Drawing.Size(191, 29);
            this.txtMaster.TabIndex = 11;
            this.txtMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaster.Leave += new System.EventHandler(this.txtTransferencia_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(53, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Master:";
            // 
            // txtVisa
            // 
            this.txtVisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVisa.Location = new System.Drawing.Point(186, 183);
            this.txtVisa.MaxLength = 20;
            this.txtVisa.Name = "txtVisa";
            this.txtVisa.Size = new System.Drawing.Size(191, 29);
            this.txtVisa.TabIndex = 9;
            this.txtVisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVisa.Leave += new System.EventHandler(this.txtTransferencia_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(53, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Visa:";
            // 
            // txtTransferencia
            // 
            this.txtTransferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTransferencia.Location = new System.Drawing.Point(186, 148);
            this.txtTransferencia.MaxLength = 20;
            this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(191, 29);
            this.txtTransferencia.TabIndex = 7;
            this.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTransferencia.Leave += new System.EventHandler(this.txtTransferencia_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(53, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transferencia:";
            // 
            // txtPagoMovil
            // 
            this.txtPagoMovil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPagoMovil.Location = new System.Drawing.Point(186, 113);
            this.txtPagoMovil.MaxLength = 20;
            this.txtPagoMovil.Name = "txtPagoMovil";
            this.txtPagoMovil.Size = new System.Drawing.Size(191, 29);
            this.txtPagoMovil.TabIndex = 5;
            this.txtPagoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagoMovil.Leave += new System.EventHandler(this.txtPagoMovil_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago Movil:";
            // 
            // txtDebito
            // 
            this.txtDebito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDebito.Location = new System.Drawing.Point(186, 78);
            this.txtDebito.MaxLength = 20;
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(191, 29);
            this.txtDebito.TabIndex = 3;
            this.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebito.Leave += new System.EventHandler(this.txtDebito_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Débito:";
            // 
            // txtDolar
            // 
            this.txtDolar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDolar.Location = new System.Drawing.Point(186, 43);
            this.txtDolar.MaxLength = 20;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(191, 29);
            this.txtDolar.TabIndex = 1;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divisas:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(463, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 86);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(463, 79);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 86);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar ";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTotalBolivaresPagar
            // 
            this.lblTotalBolivaresPagar.AutoSize = true;
            this.lblTotalBolivaresPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBolivaresPagar.Location = new System.Drawing.Point(303, 9);
            this.lblTotalBolivaresPagar.Name = "lblTotalBolivaresPagar";
            this.lblTotalBolivaresPagar.Size = new System.Drawing.Size(76, 25);
            this.lblTotalBolivaresPagar.TabIndex = 16;
            this.lblTotalBolivaresPagar.Text = "label8";
            this.lblTotalBolivaresPagar.Visible = false;
            // 
            // lblTotalDolaresPagar
            // 
            this.lblTotalDolaresPagar.AutoSize = true;
            this.lblTotalDolaresPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDolaresPagar.Location = new System.Drawing.Point(190, 9);
            this.lblTotalDolaresPagar.Name = "lblTotalDolaresPagar";
            this.lblTotalDolaresPagar.Size = new System.Drawing.Size(76, 25);
            this.lblTotalDolaresPagar.TabIndex = 17;
            this.lblTotalDolaresPagar.Text = "label8";
            this.lblTotalDolaresPagar.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(37, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total $:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(244, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Bs:";
            // 
            // lblPreciodelDolar
            // 
            this.lblPreciodelDolar.AutoSize = true;
            this.lblPreciodelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreciodelDolar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPreciodelDolar.Location = new System.Drawing.Point(458, 38);
            this.lblPreciodelDolar.Name = "lblPreciodelDolar";
            this.lblPreciodelDolar.Size = new System.Drawing.Size(76, 25);
            this.lblPreciodelDolar.TabIndex = 19;
            this.lblPreciodelDolar.Text = "label8";
            // 
            // lblBolivares
            // 
            this.lblBolivares.AutoSize = true;
            this.lblBolivares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBolivares.Location = new System.Drawing.Point(323, 385);
            this.lblBolivares.Name = "lblBolivares";
            this.lblBolivares.Size = new System.Drawing.Size(92, 31);
            this.lblBolivares.TabIndex = 20;
            this.lblBolivares.Text = "label8";
            // 
            // lbldolares
            // 
            this.lbldolares.AutoSize = true;
            this.lbldolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolares.Location = new System.Drawing.Point(114, 384);
            this.lbldolares.Name = "lbldolares";
            this.lbldolares.Size = new System.Drawing.Size(92, 31);
            this.lbldolares.TabIndex = 21;
            this.lbldolares.Text = "label8";
            // 
            // lblIdv
            // 
            this.lblIdv.AutoSize = true;
            this.lblIdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdv.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIdv.Location = new System.Drawing.Point(261, 408);
            this.lblIdv.Name = "lblIdv";
            this.lblIdv.Size = new System.Drawing.Size(76, 25);
            this.lblIdv.TabIndex = 22;
            this.lblIdv.Text = "label8";
            this.lblIdv.Visible = false;
            // 
            // lblexento
            // 
            this.lblexento.AutoSize = true;
            this.lblexento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblexento.Location = new System.Drawing.Point(45, 408);
            this.lblexento.Name = "lblexento";
            this.lblexento.Size = new System.Drawing.Size(82, 24);
            this.lblexento.TabIndex = 23;
            this.lblexento.Text = "Total Bs:";
            this.lblexento.Visible = false;
            // 
            // lblIvaBolivares
            // 
            this.lblIvaBolivares.AutoSize = true;
            this.lblIvaBolivares.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIvaBolivares.Location = new System.Drawing.Point(406, 9);
            this.lblIvaBolivares.Name = "lblIvaBolivares";
            this.lblIvaBolivares.Size = new System.Drawing.Size(82, 24);
            this.lblIvaBolivares.TabIndex = 24;
            this.lblIvaBolivares.Text = "Total Bs:";
            this.lblIvaBolivares.Visible = false;
            // 
            // lblSubtotalbolivares
            // 
            this.lblSubtotalbolivares.AutoSize = true;
            this.lblSubtotalbolivares.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubtotalbolivares.Location = new System.Drawing.Point(494, 9);
            this.lblSubtotalbolivares.Name = "lblSubtotalbolivares";
            this.lblSubtotalbolivares.Size = new System.Drawing.Size(82, 24);
            this.lblSubtotalbolivares.TabIndex = 25;
            this.lblSubtotalbolivares.Text = "Total Bs:";
            this.lblSubtotalbolivares.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(472, 320);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 24);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Total Bs:";
            this.lblNombre.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(452, 351);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 24);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Total Bs:";
            this.lblTipo.Visible = false;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltelefono.Location = new System.Drawing.Point(472, 375);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(82, 24);
            this.lbltelefono.TabIndex = 28;
            this.lbltelefono.Text = "Total Bs:";
            this.lbltelefono.Visible = false;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirección.Location = new System.Drawing.Point(472, 399);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(82, 24);
            this.lblDirección.TabIndex = 29;
            this.lblDirección.Text = "Total Bs:";
            this.lblDirección.Visible = false;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCedula.Location = new System.Drawing.Point(540, 351);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(82, 24);
            this.lblCedula.TabIndex = 30;
            this.lblCedula.Text = "Total Bs:";
            this.lblCedula.Visible = false;
            // 
            // FrmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSubtotalbolivares);
            this.Controls.Add(this.lblIvaBolivares);
            this.Controls.Add(this.lblexento);
            this.Controls.Add(this.lblIdv);
            this.Controls.Add(this.lbldolares);
            this.Controls.Add(this.lblBolivares);
            this.Controls.Add(this.lblPreciodelDolar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalDolaresPagar);
            this.Controls.Add(this.lblTotalBolivaresPagar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmPagar";
            this.Text = ".:. Formas de Pago .:.";
            this.Load += new System.EventHandler(this.FrmPagar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagoMovil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblTotalBolivaresPagar;
        public System.Windows.Forms.Label lblTotalDolaresPagar;
        protected System.Windows.Forms.Label lblPreciodelDolar;
        protected System.Windows.Forms.Label lblBolivares;
        protected System.Windows.Forms.Label lbldolares;
        protected System.Windows.Forms.Label lblIdv;
        public System.Windows.Forms.Label lblexento;
        public System.Windows.Forms.Label lblIvaBolivares;
        public System.Windows.Forms.Label lblSubtotalbolivares;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lbltelefono;
        public System.Windows.Forms.Label lblDirección;
        public System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label10;
    }
}