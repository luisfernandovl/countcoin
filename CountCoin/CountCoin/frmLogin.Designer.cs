namespace CountCoin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblBorder1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblBorder2 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.picLogoTipo = new System.Windows.Forms.PictureBox();
            this.picLogoMarca = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.mkdTxtCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(393, 122);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 18);
            this.lblCPF.TabIndex = 158;
            this.lblCPF.Text = "CPF*: ";
            // 
            // lblBorder1
            // 
            this.lblBorder1.AutoSize = true;
            this.lblBorder1.Location = new System.Drawing.Point(388, 140);
            this.lblBorder1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder1.Name = "lblBorder1";
            this.lblBorder1.Size = new System.Drawing.Size(216, 18);
            this.lblBorder1.TabIndex = 160;
            this.lblBorder1.Text = "[_________________________]";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSenha.Location = new System.Drawing.Point(396, 205);
            this.txtSenha.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 17);
            this.txtSenha.TabIndex = 162;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblBorder2
            // 
            this.lblBorder2.AutoSize = true;
            this.lblBorder2.Location = new System.Drawing.Point(388, 205);
            this.lblBorder2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder2.Name = "lblBorder2";
            this.lblBorder2.Size = new System.Drawing.Size(216, 18);
            this.lblBorder2.TabIndex = 163;
            this.lblBorder2.Text = "[_________________________]";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(393, 184);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 18);
            this.lblSenha.TabIndex = 161;
            this.lblSenha.Text = "Senha*: ";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(618, 9);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(24, 24);
            this.btnSair.TabIndex = 167;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "&X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picLogoTipo
            // 
            this.picLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("picLogoTipo.Image")));
            this.picLogoTipo.Location = new System.Drawing.Point(396, 45);
            this.picLogoTipo.Name = "picLogoTipo";
            this.picLogoTipo.Size = new System.Drawing.Size(192, 56);
            this.picLogoTipo.TabIndex = 3;
            this.picLogoTipo.TabStop = false;
            // 
            // picLogoMarca
            // 
            this.picLogoMarca.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMarca.Image")));
            this.picLogoMarca.Location = new System.Drawing.Point(45, 45);
            this.picLogoMarca.Name = "picLogoMarca";
            this.picLogoMarca.Size = new System.Drawing.Size(300, 300);
            this.picLogoMarca.TabIndex = 165;
            this.picLogoMarca.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(392, 259);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 32);
            this.btnLogin.TabIndex = 164;
            this.btnLogin.Text = "Fazer &Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair1
            // 
            this.btnSair1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnSair1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.Location = new System.Drawing.Point(392, 313);
            this.btnSair1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(213, 32);
            this.btnSair1.TabIndex = 165;
            this.btnSair1.Text = "&Sair";
            this.btnSair1.UseVisualStyleBackColor = false;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // linkCadastro
            // 
            this.linkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(134)))));
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastro.ForeColor = System.Drawing.Color.PowderBlue;
            this.linkCadastro.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkCadastro.Location = new System.Drawing.Point(533, 225);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(73, 15);
            this.linkCadastro.TabIndex = 166;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "&Cadastre-se";
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // mkdTxtCPF
            // 
            this.mkdTxtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.mkdTxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkdTxtCPF.ForeColor = System.Drawing.Color.Gainsboro;
            this.mkdTxtCPF.Location = new System.Drawing.Point(396, 140);
            this.mkdTxtCPF.Mask = "999,999,999-99";
            this.mkdTxtCPF.Name = "mkdTxtCPF";
            this.mkdTxtCPF.Size = new System.Drawing.Size(200, 17);
            this.mkdTxtCPF.TabIndex = 159;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(652, 390);
            this.Controls.Add(this.mkdTxtCPF);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picLogoMarca);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblBorder1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblBorder2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.picLogoTipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblBorder1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblBorder2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picLogoTipo;
        private System.Windows.Forms.PictureBox picLogoMarca;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.MaskedTextBox mkdTxtCPF;
    }
}