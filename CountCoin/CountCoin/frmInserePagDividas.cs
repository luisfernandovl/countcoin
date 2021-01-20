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
    public partial class frmInserePagDividas : Form
    {
        private string id_cpf, nome, usuario, cidade, estado, tel, ocupacao, email, senha;
        private DateTime data_nasc;
        public frmInserePagDividas()
        {
            InitializeComponent();
        }
        private void frmInserePagDividas_Load(object sender, EventArgs e)
        {
            numValorPag.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregaInfos()
        {
            try
            {
                string sql = "SELECT id_divida,id_cpf,categoria,descricao,valor,data_venc,parcel,qtdparcel,pago" +
                             " FROM divida WHERE id_divida =@1";
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
       /* private void setInfosNoForm()
        {
            mkdTxtCPF.Text = id_cpf;
            txtDescricao.Text = nome;
            txtValorTotal.Text = usuario;
            dtpDatVenc.Value = data_nasc;
            txtCidade.Text = cidade;
            cmbEstado.Text = estado;
            mkdTxtTelefone.Text = tel;
            txtOcupacao.Text = ocupacao;
            txtEmail.Text = email;
            txtSenha.Text = senha;
            txtConfSenha.Text = senha;
        }*/

        //-------------------------------------------------------
        //Botões Pagar e Cancelar -------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------
    }
}
