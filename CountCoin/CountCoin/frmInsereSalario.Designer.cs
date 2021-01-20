namespace CountCoin
{
    partial class frmInsereSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsereSalario));
            this.lblR1 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.btnTipo1 = new System.Windows.Forms.Button();
            this.lblBorder2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBorder1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnTipo2 = new System.Windows.Forms.Button();
            this.btnTipo3 = new System.Windows.Forms.Button();
            this.dtpDatReceb = new System.Windows.Forms.DateTimePicker();
            this.lblDatVenc = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblR1
            // 
            this.lblR1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblR1.AutoSize = true;
            this.lblR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1.Location = new System.Drawing.Point(533, 114);
            this.lblR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(30, 20);
            this.lblR1.TabIndex = 104;
            this.lblR1.Text = "R$";
            // 
            // numValor
            // 
            this.numValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValor.DecimalPlaces = 2;
            this.numValor.ForeColor = System.Drawing.Color.Gainsboro;
            this.numValor.Location = new System.Drawing.Point(363, 114);
            this.numValor.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(186, 20);
            this.numValor.TabIndex = 90;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numValor, "Valor recebido");
            // 
            // btnTipo1
            // 
            this.btnTipo1.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo1.FlatAppearance.BorderSize = 2;
            this.btnTipo1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo1.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo1.Image")));
            this.btnTipo1.Location = new System.Drawing.Point(27, 55);
            this.btnTipo1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo1.Name = "btnTipo1";
            this.btnTipo1.Size = new System.Drawing.Size(96, 96);
            this.btnTipo1.TabIndex = 77;
            this.btnTipo1.UseVisualStyleBackColor = false;
            this.btnTipo1.Click += new System.EventHandler(this.btnTipo1_Click);
            // 
            // lblBorder2
            // 
            this.lblBorder2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder2.AutoSize = true;
            this.lblBorder2.Location = new System.Drawing.Point(355, 117);
            this.lblBorder2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder2.Name = "lblBorder2";
            this.lblBorder2.Size = new System.Drawing.Size(216, 18);
            this.lblBorder2.TabIndex = 101;
            this.lblBorder2.Text = "[_________________________]";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNome.Location = new System.Drawing.Point(363, 38);
            this.txtNome.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 17);
            this.txtNome.TabIndex = 89;
            // 
            // lblBorder1
            // 
            this.lblBorder1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder1.AutoSize = true;
            this.lblBorder1.Location = new System.Drawing.Point(355, 38);
            this.lblBorder1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder1.Name = "lblBorder1";
            this.lblBorder1.Size = new System.Drawing.Size(216, 18);
            this.lblBorder1.TabIndex = 100;
            this.lblBorder1.Text = "[_________________________]";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(607, 150);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 98;
            this.btnCancelar.Text = "&Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Apagar as informações");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(360, 20);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(114, 18);
            this.lblDescricao.TabIndex = 86;
            this.lblDescricao.Text = "Quem recebeu?";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "&X";
            this.toolTip1.SetToolTip(this.btnClose, "Fechar formulário");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(607, 76);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 32);
            this.btnRegistrar.TabIndex = 97;
            this.btnRegistrar.Text = "&Registrar";
            this.toolTip1.SetToolTip(this.btnRegistrar, "Registrar recebimento");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnTipo2
            // 
            this.btnTipo2.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo2.FlatAppearance.BorderSize = 2;
            this.btnTipo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo2.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo2.Image")));
            this.btnTipo2.Location = new System.Drawing.Point(131, 55);
            this.btnTipo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo2.Name = "btnTipo2";
            this.btnTipo2.Size = new System.Drawing.Size(96, 96);
            this.btnTipo2.TabIndex = 106;
            this.btnTipo2.UseVisualStyleBackColor = false;
            this.btnTipo2.Click += new System.EventHandler(this.btnTipo2_Click);
            // 
            // btnTipo3
            // 
            this.btnTipo3.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo3.FlatAppearance.BorderSize = 2;
            this.btnTipo3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo3.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo3.Image")));
            this.btnTipo3.Location = new System.Drawing.Point(235, 55);
            this.btnTipo3.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo3.Name = "btnTipo3";
            this.btnTipo3.Size = new System.Drawing.Size(96, 96);
            this.btnTipo3.TabIndex = 107;
            this.btnTipo3.UseVisualStyleBackColor = false;
            this.btnTipo3.Click += new System.EventHandler(this.btnTipo3_Click);
            // 
            // dtpDatReceb
            // 
            this.dtpDatReceb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDatReceb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpDatReceb.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatReceb.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatReceb.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatReceb.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatReceb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatReceb.Location = new System.Drawing.Point(364, 193);
            this.dtpDatReceb.MaximumSize = new System.Drawing.Size(199, 24);
            this.dtpDatReceb.Name = "dtpDatReceb";
            this.dtpDatReceb.Size = new System.Drawing.Size(199, 24);
            this.dtpDatReceb.TabIndex = 92;
            this.dtpDatReceb.Value = new System.DateTime(2020, 1, 9, 21, 55, 7, 0);
            // 
            // lblDatVenc
            // 
            this.lblDatVenc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatVenc.AutoSize = true;
            this.lblDatVenc.Location = new System.Drawing.Point(360, 172);
            this.lblDatVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatVenc.Name = "lblDatVenc";
            this.lblDatVenc.Size = new System.Drawing.Size(154, 18);
            this.lblDatVenc.TabIndex = 91;
            this.lblDatVenc.Text = "Data do recebimento: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(360, 96);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(65, 18);
            this.lblValorTotal.TabIndex = 88;
            this.lblValorTotal.Text = "Quanto?";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(57, 20);
            this.lblTipoConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(206, 18);
            this.lblTipoConta.TabIndex = 84;
            this.lblTipoConta.Text = "Qual é o tipo de recebimento?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 108;
            this.label1.Text = "Dinheiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 109;
            this.label2.Text = "Cartão \r\nAlimentação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 36);
            this.label3.TabIndex = 110;
            this.label3.Text = "Vale \r\nTransporte";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInsereSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTipo3);
            this.Controls.Add(this.btnTipo2);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.btnTipo1);
            this.Controls.Add(this.lblBorder2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBorder1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpDatReceb);
            this.Controls.Add(this.lblDatVenc);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.btnRegistrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsereSalario";
            this.Text = "frmInsereSalario";
            this.Load += new System.EventHandler(this.frmInsereSalario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTipo1;
        private System.Windows.Forms.Label lblBorder2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBorder1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpDatReceb;
        private System.Windows.Forms.Label lblDatVenc;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Button btnTipo2;
        private System.Windows.Forms.Button btnTipo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}