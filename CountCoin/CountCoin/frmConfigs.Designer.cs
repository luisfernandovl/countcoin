namespace CountCoin
{
    partial class frmConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigs));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtFonte = new System.Windows.Forms.TextBox();
            this.lblBorder = new System.Windows.Forms.Label();
            this.lblTamFonte = new System.Windows.Forms.Label();
            this.btnCorFonte = new System.Windows.Forms.Button();
            this.lblCorFonte = new System.Windows.Forms.Label();
            this.btnCor1 = new System.Windows.Forms.Button();
            this.lblTemaPers = new System.Windows.Forms.Label();
            this.btnBorder = new System.Windows.Forms.Button();
            this.btnCor2 = new System.Windows.Forms.Button();
            this.btnCor3 = new System.Windows.Forms.Button();
            this.cmbFonte = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnMoon = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(155, 305);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(18, 39);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(60, 18);
            this.lblTema.TabIndex = 124;
            this.lblTema.Text = "Tema*: ";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(256, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 139;
            this.btnClose.Text = "&X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Location = new System.Drawing.Point(13, 305);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(112, 32);
            this.btnAplicar.TabIndex = 137;
            this.btnAplicar.Text = "&Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // txtFonte
            // 
            this.txtFonte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFonte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFonte.Enabled = false;
            this.txtFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonte.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFonte.Location = new System.Drawing.Point(21, 99);
            this.txtFonte.MaximumSize = new System.Drawing.Size(200, 17);
            this.txtFonte.Name = "txtFonte";
            this.txtFonte.Size = new System.Drawing.Size(158, 17);
            this.txtFonte.TabIndex = 128;
            this.txtFonte.Text = "Fonte";
            // 
            // lblBorder
            // 
            this.lblBorder.AutoSize = true;
            this.lblBorder.Location = new System.Drawing.Point(13, 99);
            this.lblBorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(176, 18);
            this.lblBorder.TabIndex = 129;
            this.lblBorder.Text = "[____________________]";
            // 
            // lblTamFonte
            // 
            this.lblTamFonte.AutoSize = true;
            this.lblTamFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamFonte.Location = new System.Drawing.Point(18, 78);
            this.lblTamFonte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamFonte.Name = "lblTamFonte";
            this.lblTamFonte.Size = new System.Drawing.Size(142, 18);
            this.lblTamFonte.TabIndex = 127;
            this.lblTamFonte.Text = "Tamanho da fonte*: ";
            // 
            // btnCorFonte
            // 
            this.btnCorFonte.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCorFonte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCorFonte.FlatAppearance.BorderSize = 4;
            this.btnCorFonte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorFonte.Location = new System.Drawing.Point(185, 146);
            this.btnCorFonte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorFonte.Name = "btnCorFonte";
            this.btnCorFonte.Size = new System.Drawing.Size(60, 18);
            this.btnCorFonte.TabIndex = 132;
            this.btnCorFonte.UseVisualStyleBackColor = false;
            this.btnCorFonte.Click += new System.EventHandler(this.btnCorFont_Click);
            // 
            // lblCorFonte
            // 
            this.lblCorFonte.AutoSize = true;
            this.lblCorFonte.Location = new System.Drawing.Point(18, 146);
            this.lblCorFonte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorFonte.Name = "lblCorFonte";
            this.lblCorFonte.Size = new System.Drawing.Size(98, 18);
            this.lblCorFonte.TabIndex = 131;
            this.lblCorFonte.Text = "Cor da fonte: ";
            // 
            // btnCor1
            // 
            this.btnCor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCor1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCor1.FlatAppearance.BorderSize = 4;
            this.btnCor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor1.Location = new System.Drawing.Point(21, 240);
            this.btnCor1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCor1.Name = "btnCor1";
            this.btnCor1.Size = new System.Drawing.Size(60, 18);
            this.btnCor1.TabIndex = 134;
            this.btnCor1.UseVisualStyleBackColor = false;
            this.btnCor1.Click += new System.EventHandler(this.btnCor1_Click);
            // 
            // lblTemaPers
            // 
            this.lblTemaPers.AutoSize = true;
            this.lblTemaPers.Location = new System.Drawing.Point(18, 194);
            this.lblTemaPers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemaPers.Name = "lblTemaPers";
            this.lblTemaPers.Size = new System.Drawing.Size(155, 18);
            this.lblTemaPers.TabIndex = 133;
            this.lblTemaPers.Text = "Tema personalizado:  ";
            // 
            // btnBorder
            // 
            this.btnBorder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorder.FlatAppearance.BorderSize = 0;
            this.btnBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorder.Location = new System.Drawing.Point(0, 0);
            this.btnBorder.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Size = new System.Drawing.Size(252, 24);
            this.btnBorder.TabIndex = 123;
            this.btnBorder.TabStop = false;
            this.btnBorder.UseVisualStyleBackColor = false;
            this.btnBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBorder_MouseDown);
            this.btnBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorder_MouseMove);
            this.btnBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBorder_MouseUp);
            // 
            // btnCor2
            // 
            this.btnCor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnCor2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCor2.FlatAppearance.BorderSize = 4;
            this.btnCor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor2.Location = new System.Drawing.Point(103, 240);
            this.btnCor2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCor2.Name = "btnCor2";
            this.btnCor2.Size = new System.Drawing.Size(60, 18);
            this.btnCor2.TabIndex = 135;
            this.btnCor2.UseVisualStyleBackColor = false;
            this.btnCor2.Click += new System.EventHandler(this.btnCor2_Click);
            // 
            // btnCor3
            // 
            this.btnCor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.btnCor3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCor3.FlatAppearance.BorderSize = 4;
            this.btnCor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor3.Location = new System.Drawing.Point(185, 240);
            this.btnCor3.Margin = new System.Windows.Forms.Padding(4);
            this.btnCor3.Name = "btnCor3";
            this.btnCor3.Size = new System.Drawing.Size(60, 18);
            this.btnCor3.TabIndex = 136;
            this.btnCor3.UseVisualStyleBackColor = false;
            this.btnCor3.Click += new System.EventHandler(this.btnCor3_Click);
            // 
            // cmbFonte
            // 
            this.cmbFonte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.cmbFonte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFonte.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFonte.FormatString = "N2";
            this.cmbFonte.FormattingEnabled = true;
            this.cmbFonte.Items.AddRange(new object[] {
            "11,25",
            "12",
            "14,25"});
            this.cmbFonte.Location = new System.Drawing.Point(185, 91);
            this.cmbFonte.Name = "cmbFonte";
            this.cmbFonte.Size = new System.Drawing.Size(60, 26);
            this.cmbFonte.TabIndex = 130;
            // 
            // btnMoon
            // 
            this.btnMoon.BackColor = System.Drawing.Color.Indigo;
            this.btnMoon.Enabled = false;
            this.btnMoon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoon.Image = ((System.Drawing.Image)(resources.GetObject("btnMoon.Image")));
            this.btnMoon.Location = new System.Drawing.Point(185, 39);
            this.btnMoon.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(28, 28);
            this.btnMoon.TabIndex = 125;
            this.btnMoon.UseVisualStyleBackColor = false;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // btnSun
            // 
            this.btnSun.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSun.Image = ((System.Drawing.Image)(resources.GetObject("btnSun.Image")));
            this.btnSun.Location = new System.Drawing.Point(217, 39);
            this.btnSun.Margin = new System.Windows.Forms.Padding(4);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(28, 28);
            this.btnSun.TabIndex = 126;
            this.btnSun.UseVisualStyleBackColor = false;
            this.btnSun.Click += new System.EventHandler(this.btnSun_Click);
            // 
            // frmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(280, 350);
            this.Controls.Add(this.btnSun);
            this.Controls.Add(this.btnMoon);
            this.Controls.Add(this.cmbFonte);
            this.Controls.Add(this.btnCor3);
            this.Controls.Add(this.btnCor2);
            this.Controls.Add(this.btnBorder);
            this.Controls.Add(this.btnCor1);
            this.Controls.Add(this.lblTemaPers);
            this.Controls.Add(this.btnCorFonte);
            this.Controls.Add(this.lblCorFonte);
            this.Controls.Add(this.txtFonte);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.lblTamFonte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAplicar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfigs";
            this.Load += new System.EventHandler(this.frmConfigs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtFonte;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Label lblTamFonte;
        private System.Windows.Forms.Button btnCorFonte;
        private System.Windows.Forms.Label lblCorFonte;
        private System.Windows.Forms.Button btnCor1;
        private System.Windows.Forms.Label lblTemaPers;
        private System.Windows.Forms.Button btnBorder;
        private System.Windows.Forms.Button btnCor2;
        private System.Windows.Forms.Button btnCor3;
        private System.Windows.Forms.ComboBox cmbFonte;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnMoon;
        private System.Windows.Forms.Button btnSun;
    }
}