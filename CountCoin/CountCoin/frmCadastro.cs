using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;

namespace CountCoin
{
    public partial class frmCadastro : Form
    {
        private Form frmSplashScreen;
        private Form frmLogin;
        //Funções de inicialização -----------------------------
        public frmCadastro(Form frmSplashScreen, Form frmLogin)
        {
            this.frmSplashScreen = frmSplashScreen;
            this.frmLogin = frmLogin;
            InitializeComponent();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            dtpDatNasc.Value = DateTime.Now;
            mkdTxtCPF.Focus();
        }
        //Funções de fechamento --------------------------------
        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formsClose();
            closeOrChange(3);
            e.Cancel = true;
        }
        private void formsClose()
        {
            frmSplashScreen.Close();
            frmSplashScreen.Dispose();
            frmLogin.Close();
            frmLogin.Dispose();
        }
        private void closeOrChange(int c)
        {
            string cC = "", cC1 = "";
            if (c == 2)
            {
                cC = "voltar para a tela de Login";
                cC1 = "Voltar";
            }
            if (c == 3)
            {
                cC = "sair do sistema";
                cC1 = "Sair";
            }
            DialogResult resp = MessageBox.Show("Deseja " + cC + "?", cC1,
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes && c == 2)
            {
                frmLogin Login = new frmLogin(this.frmSplashScreen);
                Login.Show();
                this.Hide();
            }

            if (resp == DialogResult.Yes && c == 3)
            {
                formsClose();
            }
        }
        //Testes de consistência -------------------------------
        private int testCamp(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return 0;
            else
                return 1;
        }
        private int testCampMkd(MaskedTextBox txt)
        {
            if (mkdTxtCPF.Text=="   .   .   -")
            {
                return 0;
            }
            else
                return 1;
        }
        private int testData(DateTimePicker dtp, string s)
        {
            if (dtp.Value.Date>=DateTime.Today)
            {
               MessageBox.Show("Preencha o campo " + s + " corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp.Focus();
                return 0;
            }
            else
                return 1;
        }
        private int testCmb(ComboBox cmb)
        {
            if (String.IsNullOrEmpty(cmb.Text))
            {
                /*MessageBox.Show("Preencha o campo " + s + "!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb.Focus();*/
                return 0;
            }
            else
                return 1;
        }
        private bool confCamp(MaskedTextBox txt0, TextBox txt1, DateTimePicker dtp, string s2,TextBox txt3, ComboBox cmb, TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8)
        {
            int t0, t1, t2, t3, t4, t5, t6, t7, t8, t9;
            t0 = testCampMkd(txt0);
            t1 = testCamp(txt1);
            t2 = testData(dtp, s2);
            t3 = testCamp(txt3);
            t4 = testCmb(cmb);
            t5 = testCamp(txt5);
            t6 = testCamp(txt6); 
            t7 = testCamp(txt7);
            t8 = testCamp(txt8);

            if (t0 == 1 && t1 == 1 && t2 == 1 && t3 == 1 && t4 == 1 && t5 == 1 && t6 == 1 && t7 == 1 && t8 == 1)
                return true;
            else
                return false;
        }
        private bool confSenha(string senha, string confSenha)
        {
            if (senha != confSenha)
            {
                MessageBox.Show("As senhas estão diferentes!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
               return true;
        }
        private void jaExistCPF(MaskedTextBox CPF)
        {
            string sql = "SELECT id_CPF FROM pessoa WHERE id_CPF = @1";
            List<object> param = new List<object>();
            param.Add(CPF.Text);
            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
            if (dr.Read())
            {
                MessageBox.Show("Este CPF já foi cadastrado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CPF.Focus();
                CPF.Clear();
                dr.Close();
            }
            dr.Close();

        }
        //Funções BD -------------------------------------------
        private void efetuarCadastro(string mkdTxtCPF, string txtNome, string txtUser, DateTime dtpDatNasc, string txtCidade, string cmbEstado, string mkdTxtTelefone, string txtOcupacao, string txtEmail, string txtSenha)
        {

            string sql;
            sql = "INSERT INTO pessoa (id_CPF, nome, usuario, data_nasc, cidade, estado, tel, ocupacao, email, senha)" +
               " VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)";
            List<object> param = new List<object>();
            param.Clear();
            param.Add(mkdTxtCPF);
            param.Add(txtNome);
            param.Add(txtUser);
            param.Add(dtpDatNasc);
            param.Add(txtCidade);
            param.Add(cmbEstado);
            param.Add(mkdTxtTelefone);
            param.Add(txtOcupacao);
            param.Add(txtEmail);
            param.Add(txtSenha);
            ConexaoBanco.executar(sql, param);
            MessageBox.Show("Cadastro realizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            closeOrChange(2);
        }
        //Caminho p/ outro form --------------------------------
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            closeOrChange(2);
        }
        //Botões -----------------------------------------------
        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true && txtConfSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtConfSenha.UseSystemPasswordChar = false;
                btnEye.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imgs\\Cadastro\\eyeOn.png");
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtConfSenha.UseSystemPasswordChar = true;
                btnEye.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imgs\\Cadastro\\eyeOff.png");
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool camp, senhas;
            int test;
            jaExistCPF(mkdTxtCPF);
            camp = confCamp(mkdTxtCPF, txtNome, dtpDatNasc, "Data de nascimento", txtCidade, cmbEstado, txtOcupacao, txtEmail, txtSenha, txtConfSenha);
            senhas = confSenha(txtSenha.Text, txtConfSenha.Text);
            test = testCamp(txtUsuario);

            if (camp == false)
                MessageBox.Show("Campos com * são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (test == 0 && !String.IsNullOrEmpty(txtNome.Text))
                txtUsuario.Text = txtNome.Text.Substring(0, txtNome.Text.IndexOf(" "));
            try
            {
                if (camp == true && senhas==true)
                    efetuarCadastro(mkdTxtCPF.Text, txtNome.Text, txtUsuario.Text, dtpDatNasc.Value.Date, txtCidade.Text, cmbEstado.Text, mkdTxtTelefone.Text, txtOcupacao.Text, txtEmail.Text, txtSenha.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mkdTxtCPF.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            dtpDatNasc.Value = DateTime.Now;
            txtCidade.Clear();
            cmbEstado.Text = "";
            mkdTxtTelefone.Clear();
            txtOcupacao.Clear();
            txtConfSenha.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }
        //-------------------------------------------------------
    }
}