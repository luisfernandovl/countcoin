namespace CountCoin
{
    partial class frmInsereDividas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsereDividas));
            this.numQtVezes = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.btnTipo9 = new System.Windows.Forms.Button();
            this.btnTipo8 = new System.Windows.Forms.Button();
            this.btnTipo7 = new System.Windows.Forms.Button();
            this.btnTipo6 = new System.Windows.Forms.Button();
            this.btnTipo5 = new System.Windows.Forms.Button();
            this.btnTipo4 = new System.Windows.Forms.Button();
            this.btnTipo3 = new System.Windows.Forms.Button();
            this.btnTipo2 = new System.Windows.Forms.Button();
            this.btnTipo1 = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblBorder3 = new System.Windows.Forms.Label();
            this.lblQtVezes = new System.Windows.Forms.Label();
            this.lblBorder2 = new System.Windows.Forms.Label();
            this.lblBorder1 = new System.Windows.Forms.Label();
            this.rdbParc = new System.Windows.Forms.RadioButton();
            this.rdbAV = new System.Windows.Forms.RadioButton();
            this.dtpDatVenc = new System.Windows.Forms.DateTimePicker();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.lblDatVenc = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.lblVezes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQtVezes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // numQtVezes
            // 
            this.numQtVezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQtVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.numQtVezes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQtVezes.Enabled = false;
            this.numQtVezes.ForeColor = System.Drawing.Color.Gainsboro;
            this.numQtVezes.Location = new System.Drawing.Point(590, 130);
            this.numQtVezes.Name = "numQtVezes";
            this.numQtVezes.Size = new System.Drawing.Size(148, 20);
            this.numQtVezes.TabIndex = 67;
            this.numQtVezes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numQtVezes, "Número de parcelas");
            this.numQtVezes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtVezes.Visible = false;
            // 
            // numValor
            // 
            this.numValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValor.DecimalPlaces = 2;
            this.numValor.ForeColor = System.Drawing.Color.Gainsboro;
            this.numValor.Location = new System.Drawing.Point(316, 160);
            this.numValor.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(186, 20);
            this.numValor.TabIndex = 61;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numValor, "Valor da divida");
            // 
            // btnTipo9
            // 
            this.btnTipo9.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo9.FlatAppearance.BorderSize = 2;
            this.btnTipo9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo9.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo9.Image")));
            this.btnTipo9.Location = new System.Drawing.Point(179, 208);
            this.btnTipo9.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo9.Name = "btnTipo9";
            this.btnTipo9.Size = new System.Drawing.Size(70, 70);
            this.btnTipo9.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnTipo9, "Outros");
            this.btnTipo9.UseVisualStyleBackColor = false;
            this.btnTipo9.Click += new System.EventHandler(this.btnTipo9_Click);
            // 
            // btnTipo8
            // 
            this.btnTipo8.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo8.FlatAppearance.BorderSize = 2;
            this.btnTipo8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo8.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo8.Image")));
            this.btnTipo8.Location = new System.Drawing.Point(103, 208);
            this.btnTipo8.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo8.Name = "btnTipo8";
            this.btnTipo8.Size = new System.Drawing.Size(70, 70);
            this.btnTipo8.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnTipo8, "Pet");
            this.btnTipo8.UseVisualStyleBackColor = false;
            this.btnTipo8.Click += new System.EventHandler(this.btnTipo8_Click);
            // 
            // btnTipo7
            // 
            this.btnTipo7.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo7.FlatAppearance.BorderSize = 2;
            this.btnTipo7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo7.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo7.Image")));
            this.btnTipo7.Location = new System.Drawing.Point(27, 208);
            this.btnTipo7.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo7.Name = "btnTipo7";
            this.btnTipo7.Size = new System.Drawing.Size(70, 70);
            this.btnTipo7.TabIndex = 54;
            this.toolTip1.SetToolTip(this.btnTipo7, "Lazer");
            this.btnTipo7.UseVisualStyleBackColor = false;
            this.btnTipo7.Click += new System.EventHandler(this.btnTipo7_Click);
            // 
            // btnTipo6
            // 
            this.btnTipo6.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo6.FlatAppearance.BorderSize = 2;
            this.btnTipo6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo6.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo6.Image")));
            this.btnTipo6.Location = new System.Drawing.Point(179, 130);
            this.btnTipo6.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo6.Name = "btnTipo6";
            this.btnTipo6.Size = new System.Drawing.Size(70, 70);
            this.btnTipo6.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btnTipo6, "Saúde");
            this.btnTipo6.UseVisualStyleBackColor = false;
            this.btnTipo6.Click += new System.EventHandler(this.btnTipo6_Click);
            // 
            // btnTipo5
            // 
            this.btnTipo5.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo5.FlatAppearance.BorderSize = 2;
            this.btnTipo5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo5.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo5.Image")));
            this.btnTipo5.Location = new System.Drawing.Point(103, 130);
            this.btnTipo5.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo5.Name = "btnTipo5";
            this.btnTipo5.Size = new System.Drawing.Size(70, 70);
            this.btnTipo5.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btnTipo5, "Educação");
            this.btnTipo5.UseVisualStyleBackColor = false;
            this.btnTipo5.Click += new System.EventHandler(this.btnTipo5_Click);
            // 
            // btnTipo4
            // 
            this.btnTipo4.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo4.FlatAppearance.BorderSize = 2;
            this.btnTipo4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo4.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo4.Image")));
            this.btnTipo4.Location = new System.Drawing.Point(27, 130);
            this.btnTipo4.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo4.Name = "btnTipo4";
            this.btnTipo4.Size = new System.Drawing.Size(70, 70);
            this.btnTipo4.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btnTipo4, "Redes");
            this.btnTipo4.UseVisualStyleBackColor = false;
            this.btnTipo4.Click += new System.EventHandler(this.btnTipo4_Click);
            // 
            // btnTipo3
            // 
            this.btnTipo3.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo3.FlatAppearance.BorderSize = 2;
            this.btnTipo3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo3.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo3.Image")));
            this.btnTipo3.Location = new System.Drawing.Point(179, 54);
            this.btnTipo3.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo3.Name = "btnTipo3";
            this.btnTipo3.Size = new System.Drawing.Size(70, 70);
            this.btnTipo3.TabIndex = 50;
            this.toolTip1.SetToolTip(this.btnTipo3, "Alimentação");
            this.btnTipo3.UseVisualStyleBackColor = false;
            this.btnTipo3.Click += new System.EventHandler(this.btnTipo3_Click);
            // 
            // btnTipo2
            // 
            this.btnTipo2.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo2.FlatAppearance.BorderSize = 2;
            this.btnTipo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo2.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo2.Image")));
            this.btnTipo2.Location = new System.Drawing.Point(103, 54);
            this.btnTipo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo2.Name = "btnTipo2";
            this.btnTipo2.Size = new System.Drawing.Size(70, 70);
            this.btnTipo2.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btnTipo2, "Transporte");
            this.btnTipo2.UseVisualStyleBackColor = false;
            this.btnTipo2.Click += new System.EventHandler(this.btnTipo2_Click);
            // 
            // btnTipo1
            // 
            this.btnTipo1.BackColor = System.Drawing.Color.Transparent;
            this.btnTipo1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo1.FlatAppearance.BorderSize = 2;
            this.btnTipo1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnTipo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo1.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo1.Image")));
            this.btnTipo1.Location = new System.Drawing.Point(27, 54);
            this.btnTipo1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipo1.Name = "btnTipo1";
            this.btnTipo1.Size = new System.Drawing.Size(70, 70);
            this.btnTipo1.TabIndex = 48;
            this.toolTip1.SetToolTip(this.btnTipo1, "Moradia");
            this.btnTipo1.UseVisualStyleBackColor = false;
            this.btnTipo1.Click += new System.EventHandler(this.btnTipo1_Click);
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
            this.txtDescricao.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.Location = new System.Drawing.Point(316, 84);
            this.txtDescricao.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 17);
            this.txtDescricao.TabIndex = 60;
            this.toolTip1.SetToolTip(this.txtDescricao, "Ex: Água");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(607, 231);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "&Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Apagar as informações");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 70;
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
            this.btnRegistrar.Location = new System.Drawing.Point(607, 169);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 32);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "&Registrar";
            this.toolTip1.SetToolTip(this.btnRegistrar, "Registrar a divida");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblR1
            // 
            this.lblR1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblR1.AutoSize = true;
            this.lblR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1.Location = new System.Drawing.Point(486, 160);
            this.lblR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(30, 20);
            this.lblR1.TabIndex = 75;
            this.lblR1.Text = "R$";
            // 
            // lblBorder3
            // 
            this.lblBorder3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorder3.AutoSize = true;
            this.lblBorder3.Enabled = false;
            this.lblBorder3.Location = new System.Drawing.Point(582, 133);
            this.lblBorder3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder3.Name = "lblBorder3";
            this.lblBorder3.Size = new System.Drawing.Size(168, 18);
            this.lblBorder3.TabIndex = 74;
            this.lblBorder3.Text = "[___________________]";
            this.lblBorder3.Visible = false;
            // 
            // lblQtVezes
            // 
            this.lblQtVezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtVezes.AutoSize = true;
            this.lblQtVezes.Enabled = false;
            this.lblQtVezes.Location = new System.Drawing.Point(581, 112);
            this.lblQtVezes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtVezes.Name = "lblQtVezes";
            this.lblQtVezes.Size = new System.Drawing.Size(144, 18);
            this.lblQtVezes.TabIndex = 73;
            this.lblQtVezes.Text = "Em quantas vezes*: ";
            this.lblQtVezes.Visible = false;
            // 
            // lblBorder2
            // 
            this.lblBorder2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder2.AutoSize = true;
            this.lblBorder2.Location = new System.Drawing.Point(308, 163);
            this.lblBorder2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder2.Name = "lblBorder2";
            this.lblBorder2.Size = new System.Drawing.Size(216, 18);
            this.lblBorder2.TabIndex = 72;
            this.lblBorder2.Text = "[_________________________]";
            // 
            // lblBorder1
            // 
            this.lblBorder1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorder1.AutoSize = true;
            this.lblBorder1.Location = new System.Drawing.Point(308, 84);
            this.lblBorder1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder1.Name = "lblBorder1";
            this.lblBorder1.Size = new System.Drawing.Size(216, 18);
            this.lblBorder1.TabIndex = 71;
            this.lblBorder1.Text = "[_________________________]";
            // 
            // rdbParc
            // 
            this.rdbParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbParc.AutoSize = true;
            this.rdbParc.Location = new System.Drawing.Point(652, 87);
            this.rdbParc.Name = "rdbParc";
            this.rdbParc.Size = new System.Drawing.Size(90, 22);
            this.rdbParc.TabIndex = 66;
            this.rdbParc.Text = "parcelada";
            this.rdbParc.UseVisualStyleBackColor = true;
            this.rdbParc.CheckedChanged += new System.EventHandler(this.rdbParc_CheckedChanged);
            // 
            // rdbAV
            // 
            this.rdbAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAV.AutoSize = true;
            this.rdbAV.Checked = true;
            this.rdbAV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rdbAV.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.rdbAV.Location = new System.Drawing.Point(576, 87);
            this.rdbAV.Name = "rdbAV";
            this.rdbAV.Size = new System.Drawing.Size(68, 22);
            this.rdbAV.TabIndex = 65;
            this.rdbAV.TabStop = true;
            this.rdbAV.Text = "à vista";
            this.rdbAV.UseVisualStyleBackColor = true;
            this.rdbAV.CheckedChanged += new System.EventHandler(this.rdbAV_CheckedChanged);
            // 
            // dtpDatVenc
            // 
            this.dtpDatVenc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDatVenc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpDatVenc.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatVenc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatVenc.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.dtpDatVenc.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpDatVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatVenc.Location = new System.Drawing.Point(317, 239);
            this.dtpDatVenc.MaximumSize = new System.Drawing.Size(199, 24);
            this.dtpDatVenc.Name = "dtpDatVenc";
            this.dtpDatVenc.Size = new System.Drawing.Size(199, 24);
            this.dtpDatVenc.TabIndex = 63;
            this.dtpDatVenc.Value = new System.DateTime(2020, 1, 9, 21, 55, 7, 0);
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Location = new System.Drawing.Point(581, 66);
            this.lblFormaPag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(152, 18);
            this.lblFormaPag.TabIndex = 64;
            this.lblFormaPag.Text = "Esta conta será paga:";
            // 
            // lblDatVenc
            // 
            this.lblDatVenc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatVenc.AutoSize = true;
            this.lblDatVenc.Location = new System.Drawing.Point(313, 218);
            this.lblDatVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatVenc.Name = "lblDatVenc";
            this.lblDatVenc.Size = new System.Drawing.Size(203, 18);
            this.lblDatVenc.TabIndex = 62;
            this.lblDatVenc.Text = "Qual é a data de vencimento?";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(313, 142);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(83, 18);
            this.lblValorTotal.TabIndex = 59;
            this.lblValorTotal.Text = "Quanto é?*";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(313, 66);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(90, 18);
            this.lblDescricao.TabIndex = 57;
            this.lblDescricao.Text = "Descrição*: ";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(57, 20);
            this.lblTipoConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(161, 18);
            this.lblTipoConta.TabIndex = 55;
            this.lblTipoConta.Text = "Qual é o tipo da conta?";
            // 
            // lblVezes
            // 
            this.lblVezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVezes.AutoSize = true;
            this.lblVezes.Enabled = false;
            this.lblVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezes.Location = new System.Drawing.Point(722, 130);
            this.lblVezes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(20, 20);
            this.lblVezes.TabIndex = 76;
            this.lblVezes.Text = "X";
            this.lblVezes.Visible = false;
            // 
            // frmInsereDividas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.lblVezes);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.btnTipo9);
            this.Controls.Add(this.btnTipo8);
            this.Controls.Add(this.btnTipo7);
            this.Controls.Add(this.btnTipo6);
            this.Controls.Add(this.btnTipo5);
            this.Controls.Add(this.btnTipo4);
            this.Controls.Add(this.btnTipo3);
            this.Controls.Add(this.btnTipo2);
            this.Controls.Add(this.btnTipo1);
            this.Controls.Add(this.lblQtVezes);
            this.Controls.Add(this.lblBorder2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblBorder1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdbParc);
            this.Controls.Add(this.rdbAV);
            this.Controls.Add(this.dtpDatVenc);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.lblDatVenc);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.numQtVezes);
            this.Controls.Add(this.lblBorder3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsereDividas";
            this.Text = "frmInsereDividas";
            this.Load += new System.EventHandler(this.frmInsereDividas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQtVezes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numQtVezes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button btnTipo9;
        private System.Windows.Forms.Button btnTipo8;
        private System.Windows.Forms.Button btnTipo7;
        private System.Windows.Forms.Button btnTipo6;
        private System.Windows.Forms.Button btnTipo5;
        private System.Windows.Forms.Button btnTipo4;
        private System.Windows.Forms.Button btnTipo3;
        private System.Windows.Forms.Button btnTipo2;
        private System.Windows.Forms.Button btnTipo1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblBorder3;
        private System.Windows.Forms.Label lblQtVezes;
        private System.Windows.Forms.Label lblBorder2;
        private System.Windows.Forms.Label lblBorder1;
        private System.Windows.Forms.RadioButton rdbParc;
        private System.Windows.Forms.RadioButton rdbAV;
        private System.Windows.Forms.DateTimePicker dtpDatVenc;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.Label lblDatVenc;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Label lblVezes;
    }
}