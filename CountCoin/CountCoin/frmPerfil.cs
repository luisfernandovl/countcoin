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
using System.IO;
namespace CountCoin
{
    public partial class frmPerfil : Form
    {
        private string id_cpf, nome, usuario, cidade, estado, tel, ocupacao, email, senha;
        private DateTime data_nasc;

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

        public frmPerfil(string cpf)
        {
            id_cpf = cpf;
            InitializeComponent();
        }
        private void frmPerfil_Load(object sender, EventArgs e)
        {
            carregaInfos();
            setInfosNoForm();
            btnSalvar.Focus();
        }
        private void carregaInfos()
        {
            try
            {
                string sql = "SELECT id_cpf,nome,usuario,data_nasc,cidade,estado,tel,ocupacao," +
                             "email,senha FROM pessoa WHERE id_cpf =@1";
                List<object> param = new List<object>();
                param.Add(id_cpf);
                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                if (dr.Read() && id_cpf == ((string)dr["id_cpf"]))
                {
                    id_cpf = (string)dr["id_cpf"];
                    nome = (string)dr["nome"];
                    usuario = (string)dr["usuario"];
                    data_nasc = (DateTime)dr["data_nasc"];
                    cidade = (string)dr["cidade"];
                    estado = (string)dr["estado"];
                    tel = (string)dr["tel"];
                    ocupacao = (string)dr["ocupacao"];
                    email = (string)dr["email"];
                    senha = (string)dr["senha"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com as informações pessoais!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setInfosNoForm()
        {
            mkdTxtCPF.Text = id_cpf;
            txtNome.Text = nome;
            txtUsuario.Text = usuario;
            dtpDatNasc.Value = data_nasc;
            txtCidade.Text = cidade;
            cmbEstado.Text = estado;
            mkdTxtTelefone.Text = tel;
            txtOcupacao.Text = ocupacao;
            txtEmail.Text = email;
            txtSenha.Text = senha;
            txtConfSenha.Text = senha;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void enabledObjs(bool TorF)
        {
            txtNome.Enabled = TorF;
            txtUsuario.Enabled = TorF;
            dtpDatNasc.Enabled = TorF;
            txtCidade.Enabled = TorF;
            cmbEstado.Enabled = TorF;
            mkdTxtTelefone.Enabled = TorF;
            txtOcupacao.Enabled = TorF;
            txtEmail.Enabled = TorF;
            txtSenha.Enabled = TorF;
            txtConfSenha.Enabled = TorF;
            btnEye.Enabled = TorF;
        }
        private int testCamp(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return 0;
            else
                return 1;
        }
        private int testCampMkd(MaskedTextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                /*MessageBox.Show("Preencha o campo " + s + "!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt.Focus();*/
                return 0;
            }
            else
                return 1;
        }
        private int testData(DateTimePicker dtp, string s)
        {
            if (dtp.Value.Date >= DateTime.Today)
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
        private bool confCamp(MaskedTextBox txt0, TextBox txt1, DateTimePicker dtp, string s2, TextBox txt3, ComboBox cmb, TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8)
        {
            int t0, t1, t2, t3, t4, t5, t6, t7, t8;
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
        private void efetuarAlteracao(string mkdTxtCPF, string txtNome, string txtUser, DateTime dtpDatNasc, string txtCidade, string cmbEstado, string mkdTxtTelefone, string txtOcupacao, string txtEmail, string txtSenha)
        {
            string sql;
            sql = "UPDATE pessoa SET id_CPF=@1, nome=@2, usuario=@3, data_nasc=@4, cidade=@5, estado=@6, tel=@7, ocupacao=@8, email=@9, senha=@10" +
               " WHERE id_CPF=@1";
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
            MessageBox.Show("Alteração realizada com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "&Alterar")
            {
                enabledObjs(true);
                mkdTxtCPF.Focus();
                btnSalvar.Text = "&Salvar";
            }else
            {
                enabledObjs(false);
                btnSalvar.Focus();
                btnSalvar.Text = "&Alterar";
                bool camp, senhas;
                int test;
                try
                {
                    camp = confCamp(mkdTxtCPF, txtNome, dtpDatNasc, "Data de nascimento", txtCidade, cmbEstado, txtOcupacao, txtEmail, txtSenha, txtConfSenha);
                    senhas = confSenha(txtSenha.Text, txtConfSenha.Text);
                    test = testCamp(txtUsuario);

                    if (camp == false)
                        MessageBox.Show("Campos com * são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (test == 0 && !String.IsNullOrEmpty(txtNome.Text))
                        txtUsuario.Text = txtNome.Text.Substring(0, txtNome.Text.IndexOf(" "));
                    if (camp == true && senhas == true)
                        efetuarAlteracao(mkdTxtCPF.Text, txtNome.Text, txtUsuario.Text, dtpDatNasc.Value.Date, txtCidade.Text, cmbEstado.Text, mkdTxtTelefone.Text, txtOcupacao.Text, txtEmail.Text, txtSenha.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao realizar a alteração!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text != "&Alterar")
                btnSalvar.Text = "&Alterar";
            setInfosNoForm();
            enabledObjs(false);
        }
    }
}
