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
    public partial class frmInsereSalario : Form
    {
        private string categoria = "";
        private string id_cpf;
        private int aux = 1;
        //Funções de inicialização ------------------------------
        public frmInsereSalario(string cpf)
        {
            this.id_cpf = cpf;
            InitializeComponent();
        }
        private void frmInsereSalario_Load(object sender, EventArgs e)
        {
            dtpDatReceb.Value = DateTime.Now;
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
        private void cancelar(TextBox txt1, NumericUpDown num1, DateTimePicker dtp)
        {
            aux = 1;
            enabledFalse(true, false);
            enabledFalse(false, true);
            txt1.Clear();
            num1.Value = Convert.ToDecimal(0.00);
            dtp.Value = DateTime.Now;
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
            if (txt.Value == 0)
                return 0;
            else
                return 1;
        }
        private bool confCamp(TextBox txt0, NumericUpDown txt1)
        {
            int t0, t1;
            t0 = testCamp(txt0);
            t1 = testNum(txt1);

            if (t0 == 1 && t1 == 1)
                return true;
            else
                return false;
        }
        private void efetuarCadastro(string categoria, string txtNome, decimal numValor, DateTime dtpDatReceb)
        {
            string sql;

            sql = "INSERT INTO recebimentos(id_receb, id_cpf, categoria, nome, valor_receb, data_receb) " +
                 "VALUES(nextval('divida_id_divida_seq'::regclass),@1,@2,@3,@4,@5)";
            List<object> param = new List<object>();
            param.Clear();
            param.Add(id_cpf);
            param.Add(categoria);
            param.Add(txtNome);
            param.Add(numValor);
            param.Add(dtpDatReceb);
            ConexaoBanco.executar(sql, param);
            MessageBox.Show("Cadastro realizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Botões para selecionar o que foi recebido ------------
        private void btnTipo1_Click(object sender, EventArgs e)
        {
            selectType(btnTipo1);
            categoria = "Dinheiro";
        }
        private void btnTipo2_Click(object sender, EventArgs e)
        {
            selectType(btnTipo2);
            categoria = "Cartão Alimentação";
        }
        private void btnTipo3_Click(object sender, EventArgs e)
        {
            selectType(btnTipo3);
            categoria = "Vale Transporte";
        }
        //Botões Registrar e Cancelar ---------------------------
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool conf = confCategoria();
            bool camp = confCamp(txtNome, numValor);
            if (camp == false)
                MessageBox.Show("Campos com * são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            try
            {
                if (conf == true && camp == true)
                {
                    efetuarCadastro(categoria, txtNome.Text, numValor.Value, dtpDatReceb.Value.Date);
                    cancelar(txtNome, numValor, dtpDatReceb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!\n\nMais detalhes: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar(txtNome, numValor, dtpDatReceb);
            
        }
        //-------------------------------------------------------
    }
}
