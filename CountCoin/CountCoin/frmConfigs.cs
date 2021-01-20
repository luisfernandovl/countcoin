using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountCoin
{
    public partial class frmConfigs : Form
    {
        //-------------------------------------------------------
        private System.Drawing.Color corF = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
        private System.Drawing.Color corX = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
        private System.Drawing.Color corY = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
        private System.Drawing.Color corZ = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
        public frmConfigs()
        {
            InitializeComponent();
            customizeColor(this.corF, this.corX, this.corY, this.corZ);
        }
        private void frmConfigs_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------
        //Movimento do Form ------------------------------------
        Point arrastarCursor;
        Point arrastarForm;
        bool arrastando;
        private void btnBorder_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            arrastarCursor = Cursor.Position;
            arrastarForm = this.Location;
        }
        private void btnBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(arrastarCursor));
                this.Location = Point.Add(arrastarForm, new Size(diferenca));
            }
        }
        private void btnBorder_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }
        //-------------------------------------------------------
        // Funções ----------------------------------------------
            //Funções que definem as cores
        private void customizeColor(System.Drawing.Color corFonte, System.Drawing.Color cor1, System.Drawing.Color cor2, System.Drawing.Color cor3)
        {
            this.BackColor = cor2;
            btnBorder.BackColor = cor2;
            btnClose.BackColor = cor2;
            btnCorFonte.BackColor = corFonte;
            btnCor1.BackColor = cor1;
            btnCor2.BackColor = cor2;
            btnCor3.BackColor = cor3;
            btnAplicar.BackColor = cor1;
            btnCancelar.BackColor = cor1;

            lblTema.ForeColor = corFonte;
            lblTamFonte.ForeColor = corFonte;
            lblCorFonte.ForeColor = corFonte;
            lblTemaPers.ForeColor = corFonte;
            txtFonte.ForeColor = corFonte;
            txtFonte.BackColor = cor2;
            lblBorder.ForeColor = corFonte;
            cmbFonte.ForeColor = corFonte;
            cmbFonte.BackColor = cor2;
        }
        private System.Drawing.Color setColor(Button btn)
        {
            if (colorDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                System.Drawing.Color color = colorDialog.Color;
                btn.BackColor = color;
            }
            return btn.BackColor;
        }
            //--------------------------
            //Funções que ativam e desativam os temas claro/escuro
        private void enabledFalse(bool a, bool b)
        {

            if (btnMoon.Enabled == a)
                btnMoon.Enabled = b;
            if (btnSun.Enabled == a)
                btnSun.Enabled = b;
            
        }
        private void enabledTrue(Button tipo)
        {
            enabledFalse(false, true);
            tipo.Enabled = false;
        }
        //-------------------------------------------------------
        //Botões de configs de cores ----------------------------
        private void btnCorFont_Click(object sender, EventArgs e)
        {
            System.Drawing.Color corFonte = setColor(btnCorFonte);
            this.corF = corFonte;

            customizeColor(this.corF, this.corX, this.corY, this.corZ);
        }
        private void btnCor1_Click(object sender, EventArgs e)
        {
            System.Drawing.Color cor1 = setColor(btnCor1);
            this.corX = cor1;

            customizeColor(this.corF, this.corX, this.corY, this.corZ);
        }
        private void btnCor2_Click(object sender, EventArgs e)
        {
            System.Drawing.Color cor2 = setColor(btnCor2);
            this.corY = cor2;

            customizeColor(corF, this.corX, this.corY, this.corZ);
        }
        private void btnCor3_Click(object sender, EventArgs e)
        {
            System.Drawing.Color cor3 = setColor(btnCor3);
            this.corZ = cor3;

            customizeColor(this.corF, this.corX, this.corY, this.corZ);
        }
        private void btnSun_Click(object sender, EventArgs e)
        {
            enabledTrue(btnSun);
            System.Drawing.Color corFonte = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            System.Drawing.Color cor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            System.Drawing.Color cor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            System.Drawing.Color cor3 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.corF = corFonte;
            this.corX = cor1;
            this.corY = cor2;
            this.corZ = cor3;
            customizeColor(corFonte, cor1, cor2, cor3);
        }
        private void btnMoon_Click(object sender, EventArgs e)
        {
            enabledTrue(btnMoon);
            System.Drawing.Color corFonte = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            System.Drawing.Color cor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            System.Drawing.Color cor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            System.Drawing.Color cor3 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.corF = corFonte;
            this.corX = cor1;
            this.corY = cor2;
            this.corZ = cor3;
            customizeColor(corFonte, cor1, cor2, cor3);
        }
        //-------------------------------------------------------
    }
}
