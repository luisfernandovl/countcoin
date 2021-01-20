using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CountCoin
{
    public partial class frmLogin : Form
    {
        private Form frmSplashScreen;
        //------------------------------------------------------
        public frmLogin(Form frmSplashScreen)
        {
            this.frmSplashScreen = frmSplashScreen;
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            mkdTxtCPF.Focus();
        }
        private void close()
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                frmSplashScreen.Close();
                frmSplashScreen.Dispose();
                this.Close();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            close();
        }
        //Testes de consistência -------------------------------
        private int testCampMkd(MaskedTextBox txt, string s)
        {
            if (String.IsNullOrEmpty(txt.Text)||txt.Text== "   .   .   -")
            {
                MessageBox.Show("Preencha o campo " + s + "!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt.Focus();
                return 0;
            }
            else
                return 1;
        }
        private int testCamp(TextBox txt, string s)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show("Preencha o campo " + s + "!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt.Focus();
                return 0;
            }
            else
                return 1;
        }
        //Acesso ao sistema ------------------------------------
        private void efetuarLogin(string mkdTxtCPF, string txtSenha)
        {
            string sql = "SELECT * FROM pessoa WHERE id_cpf=@1 AND senha=@2";
            List<object> param = new List<object>();
            param.Add(mkdTxtCPF);
            param.Add(txtSenha);
            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
            if (dr.Read() && mkdTxtCPF == ((string)dr["id_cpf"]) && txtSenha == ((string)dr["senha"]))
            {
                frmMenu Menu = new frmMenu(this.frmSplashScreen, this, mkdTxtCPF);
                dr.Close();
                Menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("CPF ou senha incorreto", "Aviso", MessageBoxButtons.OK);
            dr.Close();
        }
        //Caminho p/ outro form --------------------------------
        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro Cadastro = new frmCadastro(this.frmSplashScreen, this);
            Cadastro.Show();
            this.Hide();
        }
        //Botões -----------------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int t1, t2;
                t1=testCampMkd(mkdTxtCPF, "CPF");
                t2=testCamp(txtSenha, "Senha");
                if (t1 == 1 && t2 == 1)
                    efetuarLogin(mkdTxtCPF.Text,txtSenha.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o login!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSair1_Click(object sender, EventArgs e)
        {
            close();
        }
        //------------------------------------------------------
    }
}
