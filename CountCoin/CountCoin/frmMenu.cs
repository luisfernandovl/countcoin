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
    public partial class frmMenu : Form
    {
        private Form frmSplashScreen;
        private Form frmLogin;
        private string id_cpf, nome,usuario,cidade,estado,tel,ocupacao,email,senha;
        private DateTime data_nasc;
        //Funções de inicialização ------------------------------
        public frmMenu(Form frmSplashScreen, Form frmLogin, string cpf)
        {
            this.frmSplashScreen = frmSplashScreen;
            this.frmLogin = frmLogin;
            this.id_cpf = cpf;
            InitializeComponent();
            customizeDesing();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            carregaInfos();
            msgsPanelPrincipal();
        }
        private void msgDeBTN()
        {
            System.DateTime moment = new System.DateTime();
            moment = DateTime.Now;

            if (moment.Hour >= 5 && moment.Hour < 12)
            {
                lblMsg.Text = "Bom dia";
            }
            else if (moment.Hour >= 12 && moment.Hour < 19)
            {
                lblMsg.Text = "Boa Tarde";
            }
            else if (moment.Hour >= 19 && moment.Hour < 24 || moment.Hour >= 0 && moment.Hour < 5)
            {
                lblMsg.Text = "Boa Noite";
            }
        }
        private void msgsPanelPrincipal()
        {
            msgDeBTN();
            lblUsuario.Text = this.usuario;
            lblCod.Text = "Id: "+this.id_cpf;
        }
        //Funções de fechamento ---------------------------------
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
            if (c == 1 || c == 3)
            {
                cC = "sair do sistema";
                cC1 = "Sair";
            }
            if (c == 2)
            {
                cC = "trocar de usuário";
                cC1 = "Trocar";
            }
            DialogResult resp = MessageBox.Show("Deseja realmente " + cC + "?", cC1,
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes && cC == "trocar de usuário")
            {
                frmLogin.Close();
                frmLogin.Dispose();
                frmLogin Login = new frmLogin(this.frmSplashScreen);
                Login.Show();
                this.Dispose();
                this.Close();
            }
            if (resp == DialogResult.Yes && cC == "sair do sistema" && c == 1)
            {
                formsClose();
                this.Close();
            }
            if (resp == DialogResult.Yes && c == 3)
            {
                formsClose();
            }
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formsClose();
            closeOrChange(3);
            e.Cancel = true;
        }
        //Funções -----------------------------------------------
        private void customizeDesing()
        {
            panelContasSubmenu.Visible = false;
            panelSalariosSubmenu.Visible = false;
        }
            //Esconde os paineis de submenu
        private void hideSubMenu()
        {
            if (panelContasSubmenu.Visible == true)
                panelContasSubmenu.Visible = false;
            if (panelSalariosSubmenu.Visible == true)
                panelSalariosSubmenu.Visible = false;
            if (panelUsuarioSubmenu.Visible == true)
                panelUsuarioSubmenu.Visible = false;
        }
            //Mostra os paineis de submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }
        private void carregaInfos()
        {
            try
            {
                string sql = "SELECT id_cpf,nome,usuario,data_nasc,cidade,estado,tel,ocupacao,"+
                             "email,senha FROM pessoa WHERE id_cpf =@1";
                List<object> param = new List<object>();
                param.Add(id_cpf);
                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                if (dr.Read() && id_cpf == ((string)dr["id_cpf"]))
                {
                        id_cpf = (string)dr["id_cpf"];
                        nome = (string)dr["nome"];
                        usuario = (string)dr["usuario"];
                        data_nasc =(DateTime)dr["data_nasc"];
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
        //Função para abrir outros Forms dentro de um mesmo Form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Botões ------------------------------------------------
        private void btnContas_Click(object sender, EventArgs e)
        {
            if (panelContasSubmenu.Visible == false)
                showSubMenu(panelContasSubmenu);
            else
                hideSubMenu();
        }
        private void btnSetContas_Click(object sender, EventArgs e)
        {
            //cod
            openChildForm(new frmInsereDividas(id_cpf));
            hideSubMenu();
        }
        private void btnSetPagmts_Click(object sender, EventArgs e)
        {
            //cod
            openChildForm(new frmInserePagDividas());
            hideSubMenu();
        }
        private void btnGrafContas_Click(object sender, EventArgs e)
        {

        }
        private void btnSalarios_Click(object sender, EventArgs e)
        {
            if (panelSalariosSubmenu.Visible == false)
                showSubMenu(panelSalariosSubmenu);
            else
                hideSubMenu();
        }
        private void btnSetSalario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInsereSalario(id_cpf));
            hideSubMenu();
        }
        private void btnGrafSalario_Click(object sender, EventArgs e)
        {

        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (panelUsuarioSubmenu.Visible == false)
                showSubMenu(panelUsuarioSubmenu);
            else
                hideSubMenu();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPerfil(this.id_cpf));
            hideSubMenu();
        }
        private void btnTrocaUsuario_Click(object sender, EventArgs e)
        {
            closeOrChange(2);
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfigs Configs = new frmConfigs();
            Configs.Show();
            hideSubMenu();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            closeOrChange(1);
        }
        //-------------------------------------------------------
    }
}
