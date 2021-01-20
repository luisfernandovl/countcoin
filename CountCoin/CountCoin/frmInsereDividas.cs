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
    public partial class frmInsereDividas : Form
    {
        private string categoria="";
        private string id_cpf;
        private bool parcel=false, pag=false;
        private int aux=1;
        //Funções de inicialização ------------------------------
        public frmInsereDividas(string cpf)
        {
            this.id_cpf = cpf;
            InitializeComponent();
        }
        private void frmInsereDividas_Load(object sender, EventArgs e)
        {
            btnTipo1.Focus();
            dtpDatVenc.Value = DateTime.Now;
        }
        //Função de fechamento ----------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Funções -----------------------------------------------
        private void enabledFalse(bool a, bool b)
        {

            if (btnTipo1.Enabled == a)
                btnTipo1.Enabled = b;
            if (btnTipo2.Enabled == a)
                btnTipo2.Enabled = b;
            if (btnTipo3.Enabled == a)
                btnTipo3.Enabled = b;
            if (btnTipo4.Enabled == a)
                btnTipo4.Enabled = b;
            if (btnTipo5.Enabled == a)
                btnTipo5.Enabled = b;
            if (btnTipo6.Enabled == a)
                btnTipo6.Enabled = b;
            if (btnTipo7.Enabled == a)
                btnTipo7.Enabled = b;
            if (btnTipo8.Enabled == a)
                btnTipo8.Enabled = b;
            if (btnTipo9.Enabled == a)
                btnTipo9.Enabled = b;
        }
        private void enabledTrue(Button tipo)
        {
            if (tipo.Enabled == true)
            {
                enabledFalse(true, false);
                tipo.Enabled = true;
            }

        }
        private void selectType(Button tipo)
        {
            if (aux == 1)
            {
                enabledTrue(tipo);
                aux = 2;
            }
            else
            {
                enabledFalse(false, true);
                aux = 1;
            }
        }
        private void cancelar(TextBox txt1, NumericUpDown num1, DateTimePicker dtp, RadioButton rdb, NumericUpDown num2)
        {
            aux = 1;
            enabledFalse(true, false);
            enabledFalse(false, true);
            txt1.Clear();
            num1.Value = Convert.ToDecimal(0.00);
            dtp.Value = DateTime.Now;
            rdb.Checked = true;
            num2.Value = 1;
        }
        private void parcela(bool TorF)
        {
            lblQtVezes.Visible = TorF;
            lblQtVezes.Enabled = TorF;
            numQtVezes.Visible = TorF;
            numQtVezes.Enabled = TorF;
            lblBorder3.Visible = TorF;
            lblBorder3.Enabled = TorF;
            lblVezes.Visible = TorF;
            lblVezes.Enabled = TorF;
            numQtVezes.Focus();
        }
        private bool confCategoria()
        {
            if (aux == 1)
            {
                MessageBox.Show("É necessário informar o tipo da conta para continuar",
                                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }
        private int testCamp(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return 0;
            else
                return 1;
        }
        private int testNum(NumericUpDown txt)
        {
            if (txt.Value==0)
                return 0;
            else
                return 1;
        }
        private bool confCamp(TextBox txt0, NumericUpDown txt1, NumericUpDown txt2)
        {
            int t0, t1, t2;
            t0 = testCamp(txt0);
            t1 = testNum(txt1);
            t2 = testNum(txt2);

            if (t0 == 1 && t1 == 1 && t2 == 1)
                return true;
            else
                return false;
        }
        private void efetuarCadastro(string categoria,string txtDescricao, decimal numValor, DateTime dtpDatVenc, bool parcel, decimal numQtVezes, bool pag)
        {

            string sql;
            
            sql = "INSERT INTO dividas(id_divida, id_cpf, categoria, descricao, valor, data_venc," +
                 " parcel, qtdParcel, pago) " +
                 "VALUES(nextval('divida_id_divida_seq'::regclass),@1,@2,@3,@4,@5,@6,@7,@8)";
            List<object> param = new List<object>();
            param.Clear();
            param.Add(id_cpf);
            param.Add(categoria);
            param.Add(txtDescricao);
            param.Add(numValor);
            param.Add(dtpDatVenc);
            param.Add(parcel);
            param.Add(numQtVezes);
            param.Add(pag);
            ConexaoBanco.executar(sql, param);
            MessageBox.Show("Cadastro realizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Botões para selecionar a categoria da divida ----------
        private void btnTipo1_Click(object sender, EventArgs e)
        {
            selectType(btnTipo1);
            categoria = "Moradia";
        }
        private void btnTipo2_Click(object sender, EventArgs e)
        {
            selectType(btnTipo2);
            categoria = "Transporte";
        }
        private void btnTipo3_Click(object sender, EventArgs e)
        {
            selectType(btnTipo3);
            categoria = "Alimentação";
        }
        private void btnTipo4_Click(object sender, EventArgs e)
        {
            selectType(btnTipo4);
            categoria = "Redes";
        }
        private void btnTipo5_Click(object sender, EventArgs e)
        {
            selectType(btnTipo5);
            categoria = "Educação";
        }
        private void btnTipo6_Click(object sender, EventArgs e)
        {
            selectType(btnTipo6);
            categoria = "Saúde";
        }
        private void btnTipo7_Click(object sender, EventArgs e)
        {
            selectType(btnTipo7);
            categoria = "Lazer";
        }
        private void btnTipo8_Click(object sender, EventArgs e)
        {
            selectType(btnTipo8);
            categoria = "Pet";
        }
        private void btnTipo9_Click(object sender, EventArgs e)
        {
            selectType(btnTipo9);
            categoria = "Outros";
        }
        //Define se a conta é parcelada ou não-------------------
        private void rdbAV_CheckedChanged(object sender, EventArgs e)
        {
            parcela(false);
            numQtVezes.Value = 1;
        }
        private void rdbParc_CheckedChanged(object sender, EventArgs e)
        {
            parcela(true);
        }
        //Botões Registrar e Cancelar ---------------------------
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool conf = confCategoria();
            bool camp = confCamp(txtDescricao, numValor, numQtVezes);
            this.parcel = confParcel();
            if (camp == false)
                MessageBox.Show("Campos com * são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            try
            {
                if (conf == true && camp == true)
                {
                    efetuarCadastro(categoria, txtDescricao.Text, numValor.Value, dtpDatVenc.Value.Date, parcel, numQtVezes.Value, pag);
                    cancelar(txtDescricao, numValor, dtpDatVenc, rdbAV, numQtVezes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar(txtDescricao,numValor,dtpDatVenc,rdbAV,numQtVezes);
        }
        private bool confParcel()
        {
            if (rdbAV.Checked)
                return false;
            else
                return true;
        }
        //-------------------------------------------------------
    }
}
