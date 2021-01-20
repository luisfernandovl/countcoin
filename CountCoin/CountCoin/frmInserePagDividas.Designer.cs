namespace CountCoin
{
    partial class frmInserePagDividas
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
            this.dtpDatPag = new System.Windows.Forms.DateTimePicker();
            this.lblDatPag = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.txtValorPac = new System.Windows.Forms.TextBox();
            this.lblBorder4 = new System.Windows.Forms.Label();
            this.lblValorParc = new System.Windows.Forms.Label();
            this.lblValorPag = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblBorder3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblBorder1 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtQtVezes = new System.Windows.Forms.TextBox();
            this.lblBorder6 = new System.Windows.Forms.Label();
            this.lblQtVezes = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbParc = new System.Windows.Forms.RadioButton();
            this.rdbAV = new System.Windows.Forms.RadioButton();
            this.lblPagando = new System.Windows.Forms.Label();
            this.lblDatVenc = new System.Windows.Forms.Label();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.picTipo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numValorPag = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatVenc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPag)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatPag
            // 
            this.dtpDatPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDatPag.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpDatPag.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatPag.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatPag.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatPag.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatPag.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatPag.Location = new System.Drawing.Point(271, 219);
            this.dtpDatPag.MaximumSize = new System.Drawing.Size(199, 24);
            this.dtpDatPag.Name = "dtpDatPag";
            this.dtpDatPag.Size = new System.Drawing.Size(199, 24);
            this.dtpDatPag.TabIndex = 133;
            this.dtpDatPag.Value = new System.DateTime(2020, 1, 9, 21, 55, 7, 0);
            // 
            // lblDatPag
            // 
            this.lblDatPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDatPag.AutoSize = true;
            this.lblDatPag.Location = new System.Drawing.Point(267, 198);
            this.lblDatPag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatPag.Name = "lblDatPag";
            this.lblDatPag.Size = new System.Drawing.Size(103, 18);
            this.lblDatPag.TabIndex = 131;
            this.lblDatPag.Text = "Pago na data: ";
            // 
            // lblR3
            // 
            this.lblR3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(689, 94);
            this.lblR3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(27, 18);
            this.lblR3.TabIndex = 129;
            this.lblR3.Text = "R$";
            // 
            // txtValorPac
            // 
            this.txtValorPac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtValorPac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPac.Enabled = false;
            this.txtValorPac.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtValorPac.Location = new System.Drawing.Point(516, 95);
            this.txtValorPac.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtValorPac.Name = "txtValorPac";
            this.txtValorPac.Size = new System.Drawing.Size(174, 17);
            this.txtValorPac.TabIndex = 127;
            this.txtValorPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBorder4
            // 
            this.lblBorder4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorder4.AutoSize = true;
            this.lblBorder4.Location = new System.Drawing.Point(508, 95);
            this.lblBorder4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder4.Name = "lblBorder4";
            this.lblBorder4.Size = new System.Drawing.Size(216, 18);
            this.lblBorder4.TabIndex = 128;
            this.lblBorder4.Text = "[_________________________]";
            // 
            // lblValorParc
            // 
            this.lblValorParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorParc.AutoSize = true;
            this.lblValorParc.Location = new System.Drawing.Point(512, 77);
            this.lblValorParc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorParc.Name = "lblValorParc";
            this.lblValorParc.Size = new System.Drawing.Size(122, 18);
            this.lblValorParc.TabIndex = 126;
            this.lblValorParc.Text = "Valor da parcela: ";
            // 
            // lblValorPag
            // 
            this.lblValorPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblValorPag.AutoSize = true;
            this.lblValorPag.Location = new System.Drawing.Point(266, 135);
            this.lblValorPag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPag.Name = "lblValorPag";
            this.lblValorPag.Size = new System.Drawing.Size(152, 18);
            this.lblValorPag.TabIndex = 122;
            this.lblValorPag.Text = "Pagando no valor de: ";
            // 
            // lblR1
            // 
            this.lblR1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(443, 94);
            this.lblR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(27, 18);
            this.lblR1.TabIndex = 121;
            this.lblR1.Text = "R$";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtValorTotal.Location = new System.Drawing.Point(270, 95);
            this.txtValorTotal.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(174, 17);
            this.txtValorTotal.TabIndex = 119;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBorder3
            // 
            this.lblBorder3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder3.AutoSize = true;
            this.lblBorder3.Location = new System.Drawing.Point(262, 95);
            this.lblBorder3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder3.Name = "lblBorder3";
            this.lblBorder3.Size = new System.Drawing.Size(216, 18);
            this.lblBorder3.TabIndex = 120;
            this.lblBorder3.Text = "[_________________________]";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescricao.AutoCompleteCustomSource.AddRange(new string[] {
            "Alugel",
            "Água",
            "Agua",
            "Energia",
            "Luz",
            "Gás",
            "Material de construção",
            "Casa",
            "Carro",
            "Moto",
            "Gasolina",
            "Pneu",
            "Passe de ônibus",
            "Mercado",
            "Pizza",
            "Lanche",
            "Pastel",
            "Salgadinhos",
            "Marmita",
            "Internet",
            "Créditos do celular",
            "TV por assinatura",
            "Curso de",
            "Remédio",
            "Hospital",
            "Viagem",
            "Passeio",
            "Ração"});
            this.txtDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.Location = new System.Drawing.Point(270, 42);
            this.txtDescricao.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 17);
            this.txtDescricao.TabIndex = 117;
            // 
            // lblBorder1
            // 
            this.lblBorder1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder1.AutoSize = true;
            this.lblBorder1.Location = new System.Drawing.Point(262, 42);
            this.lblBorder1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder1.Name = "lblBorder1";
            this.lblBorder1.Size = new System.Drawing.Size(216, 18);
            this.lblBorder1.TabIndex = 118;
            this.lblBorder1.Text = "[_________________________]";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(266, 77);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(78, 18);
            this.lblValorTotal.TabIndex = 116;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(266, 24);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 18);
            this.lblDescricao.TabIndex = 115;
            this.lblDescricao.Text = "Descrição: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(105, 78);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(78, 24);
            this.lblTipo.TabIndex = 114;
            this.lblTipo.Text = "Moradia";
            // 
            // txtQtVezes
            // 
            this.txtQtVezes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtQtVezes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtVezes.Enabled = false;
            this.txtQtVezes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtQtVezes.Location = new System.Drawing.Point(27, 267);
            this.txtQtVezes.Name = "txtQtVezes";
            this.txtQtVezes.Size = new System.Drawing.Size(149, 17);
            this.txtQtVezes.TabIndex = 110;
            this.txtQtVezes.Visible = false;
            // 
            // lblBorder6
            // 
            this.lblBorder6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBorder6.AutoSize = true;
            this.lblBorder6.Enabled = false;
            this.lblBorder6.Location = new System.Drawing.Point(20, 267);
            this.lblBorder6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder6.Name = "lblBorder6";
            this.lblBorder6.Size = new System.Drawing.Size(168, 18);
            this.lblBorder6.TabIndex = 111;
            this.lblBorder6.Text = "[___________________]";
            this.lblBorder6.Visible = false;
            // 
            // lblQtVezes
            // 
            this.lblQtVezes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtVezes.AutoSize = true;
            this.lblQtVezes.Enabled = false;
            this.lblQtVezes.Location = new System.Drawing.Point(24, 249);
            this.lblQtVezes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtVezes.Name = "lblQtVezes";
            this.lblQtVezes.Size = new System.Drawing.Size(138, 18);
            this.lblQtVezes.TabIndex = 109;
            this.lblQtVezes.Text = "Em quantas vezes: ";
            this.lblQtVezes.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(631, 249);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdbParc
            // 
            this.rdbParc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdbParc.AutoSize = true;
            this.rdbParc.Enabled = false;
            this.rdbParc.Location = new System.Drawing.Point(27, 208);
            this.rdbParc.Name = "rdbParc";
            this.rdbParc.Size = new System.Drawing.Size(90, 22);
            this.rdbParc.TabIndex = 107;
            this.rdbParc.Text = "parcelada";
            this.rdbParc.UseVisualStyleBackColor = true;
            // 
            // rdbAV
            // 
            this.rdbAV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdbAV.AutoSize = true;
            this.rdbAV.Checked = true;
            this.rdbAV.Enabled = false;
            this.rdbAV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rdbAV.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.rdbAV.Location = new System.Drawing.Point(27, 170);
            this.rdbAV.Name = "rdbAV";
            this.rdbAV.Size = new System.Drawing.Size(68, 22);
            this.rdbAV.TabIndex = 106;
            this.rdbAV.TabStop = true;
            this.rdbAV.Text = "à vista";
            this.rdbAV.UseVisualStyleBackColor = true;
            // 
            // lblPagando
            // 
            this.lblPagando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPagando.AutoSize = true;
            this.lblPagando.Location = new System.Drawing.Point(24, 135);
            this.lblPagando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagando.Name = "lblPagando";
            this.lblPagando.Size = new System.Drawing.Size(92, 18);
            this.lblPagando.TabIndex = 105;
            this.lblPagando.Text = "Conta paga: ";
            // 
            // lblDatVenc
            // 
            this.lblDatVenc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatVenc.AutoSize = true;
            this.lblDatVenc.Location = new System.Drawing.Point(512, 24);
            this.lblDatVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatVenc.Name = "lblDatVenc";
            this.lblDatVenc.Size = new System.Drawing.Size(149, 18);
            this.lblDatVenc.TabIndex = 104;
            this.lblDatVenc.Text = "Data de Vencimento: ";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(24, 24);
            this.lblTipoConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(106, 18);
            this.lblTipoConta.TabIndex = 103;
            this.lblTipoConta.Text = "Tipo da conta: ";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Location = new System.Drawing.Point(511, 249);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 32);
            this.btnPagar.TabIndex = 101;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // picTipo
            // 
            this.picTipo.Location = new System.Drawing.Point(27, 54);
            this.picTipo.Name = "picTipo";
            this.picTipo.Size = new System.Drawing.Size(70, 70);
            this.picTipo.TabIndex = 130;
            this.picTipo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 135;
            this.label1.Text = "R$";
            // 
            // numValorPag
            // 
            this.numValorPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numValorPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.numValorPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValorPag.DecimalPlaces = 2;
            this.numValorPag.ForeColor = System.Drawing.Color.Gainsboro;
            this.numValorPag.Location = new System.Drawing.Point(278, 153);
            this.numValorPag.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numValorPag.Name = "numValorPag";
            this.numValorPag.Size = new System.Drawing.Size(178, 20);
            this.numValorPag.TabIndex = 132;
            this.numValorPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 134;
            this.label2.Text = "[_________________________]";
            // 
            // dtpDatVenc
            // 
            this.dtpDatVenc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDatVenc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpDatVenc.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatVenc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatVenc.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatVenc.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatVenc.Location = new System.Drawing.Point(515, 45);
            this.dtpDatVenc.MaximumSize = new System.Drawing.Size(199, 24);
            this.dtpDatVenc.Name = "dtpDatVenc";
            this.dtpDatVenc.Size = new System.Drawing.Size(199, 24);
            this.dtpDatVenc.TabIndex = 136;
            this.dtpDatVenc.Value = new System.DateTime(2020, 1, 9, 21, 55, 7, 0);
            // 
            // frmInserePagDividas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.dtpDatVenc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numValorPag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatPag);
            this.Controls.Add(this.lblDatPag);
            this.Controls.Add(this.lblR3);
            this.Controls.Add(this.txtValorPac);
            this.Controls.Add(this.lblBorder4);
            this.Controls.Add(this.lblValorParc);
            this.Controls.Add(this.lblValorPag);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblBorder3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblBorder1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtQtVezes);
            this.Controls.Add(this.lblBorder6);
            this.Controls.Add(this.lblQtVezes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdbParc);
            this.Controls.Add(this.rdbAV);
            this.Controls.Add(this.lblPagando);
            this.Controls.Add(this.lblDatVenc);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.picTipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInserePagDividas";
            this.Text = "frmInserePagDividas";
            this.Load += new System.EventHandler(this.frmInserePagDividas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatPag;
        private System.Windows.Forms.Label lblDatPag;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.TextBox txtValorPac;
        private System.Windows.Forms.Label lblBorder4;
        private System.Windows.Forms.Label lblValorParc;
        private System.Windows.Forms.Label lblValorPag;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblBorder3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblBorder1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtQtVezes;
        private System.Windows.Forms.Label lblBorder6;
        private System.Windows.Forms.Label lblQtVezes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbParc;
        private System.Windows.Forms.RadioButton rdbAV;
        private System.Windows.Forms.Label lblPagando;
        private System.Windows.Forms.Label lblDatVenc;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.PictureBox picTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValorPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatVenc;
    }
}