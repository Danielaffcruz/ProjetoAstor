using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data.SqlClient;

namespace ProjetoAstor.Formulários
{
    public partial class frmCadastroTransportadora : Form
    {
        public frmCadastroTransportadora()
        {
            InitializeComponent();
        }

        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO")
            {
                Campo = "traCodigo";
            }
            else if (cboOpcao.Text == "RAZÃO SOCIAL")
            {
                Campo = "traRazaoSocial";
            }
            else if (cboOpcao.Text == "NOME FANTASIA")
            {
                Campo = "traNomeFantasia";
            }
            else if (cboOpcao.Text == "CIDADE")
            {
                Campo = "traCidade";
            }
            else if (cboOpcao.Text == "ESTADO")
            {
                Campo = "traEstado";
            }


            //Carrega o datagridview com os clientes cadastrados
            clTransportadoras clTransportadora = new clTransportadoras();
            clTransportadora.Banco = Properties.Settings.Default.conexaoDB;
            dgvTransportadoras.DataSource = clTransportadora.Pesquisar(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvTransportadoras.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
        }

        void PesquisarCEP(string CEP)
        //PesquisarCEP é um método
        //string CEP é um argumento ou assinatura do método
        {
            //pesquisa de CEP
            DataSet ds = new DataSet();
            clGerais clGerais = new clGerais();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtEndereco.Text = clGerais.RemoveAcentos(ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString());
                txtBairro.Text = clGerais.RemoveAcentos(ds.Tables[0].Rows[0]["bairro"].ToString());
                txtCidade.Text = clGerais.RemoveAcentos(ds.Tables[0].Rows[0]["cidade"].ToString());
                cboEstado.Text = (ds.Tables[0].Rows[0]["uf"].ToString());
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Limpar()
        {
            //Limpa todos os campos do formulário
            foreach (Control ctrl in grpTransportadora.Controls)
            {
                //TextBox 
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                //ComboBox
                if (ctrl is ComboBox)
                {
                    ((ComboBox)(ctrl)).Text = String.Empty;
                }
                //MaskedTextBox 
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }

            }
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroTransportadora_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmCadastroTransportadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Envia o Tab quando for precionado o Enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Chama o método Pesquisar CEP
            PesquisarCEP(mskCEP.Text);
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            string valor = mskCNPJ.Text;
            string mensagem = "";

            if (ValidacaoCNPJ.IsCnpj(valor))
                {
                  mensagem = "CNPJ Válido !";
                }
            else
                {
                  mensagem = "CNPJ Inválido !";
                }
                MessageBox.Show(mensagem, "Validação");

            //Validação do Conteúdo 
            if (txtRazaoSocial.Text == "")
            {
                errErro.SetError(lblRazaoSocial, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblRazaoSocial, "");
            }
            if (txtNomeFantasia.Text == "")
            {
                errErro.SetError(lblNomeFantasia, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblNomeFantasia, "");
            }
            if (mskCNPJ.Text == "")
            {
                errErro.SetError(lblCNPJ, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblCNPJ, "");
            }
            if (mskTelefone.Text == "")
            {
                errErro.SetError(lblTelefone, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblTelefone, "");
            }

            //Pergunta para o Usuário se ele confirma a inclusão de Cadastro 
            DialogResult Resposta;
            if (txtCodigo.Text == "")
            {
                Resposta = MessageBox.Show("Confirmar Inclusão", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                Resposta = MessageBox.Show("Confirmar Alteração", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }



            if (Resposta.Equals(DialogResult.No))

            {
                return;
            }

            //Instancia a classe de Negocio
            clTransportadoras clTransportadora = new clTransportadoras();

            //Carrega as Propriedades
            clTransportadora.traRazaoSocial = txtRazaoSocial.Text;
            clTransportadora.traNomeFantasia = txtNomeFantasia.Text;
            clTransportadora.traCNPJ = mskCNPJ.Text;
            clTransportadora.traEmail = txtEmail.Text;
            clTransportadora.traTelefone = mskTelefone.Text;
            clTransportadora.traTelefone2 = mskTelefone2.Text;
            clTransportadora.traCEP = mskCEP.Text;
            clTransportadora.traEndereco = txtEndereco.Text;
            clTransportadora.traNumero = txtNumero.Text;
            clTransportadora.traBairro = txtBairro.Text;
            clTransportadora.traCidade = txtCidade.Text;
            clTransportadora.traEstado = cboEstado.Text;
            clTransportadora.traObservacao = txtObservacao.Text;

            //Variavel com a string de conexão com o banco de dados
            clTransportadora.Banco = Properties.Settings.Default.conexaoDB;

            //Chama o método Gravar
            if (txtCodigo.Text == "")
            {
                clTransportadora.Gravar();
                MessageBox.Show("Transportadora Incluida com Sucesso!", "Gravado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clTransportadora.traCodigo = Convert.ToInt32(txtCodigo.Text);
                clTransportadora.Alterar();
                MessageBox.Show("Transportadora Alterada com Sucesso!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Atualiza o DataGridView
            Pesquisar();

            Limpar();
        }

        private void tstExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                return;
            }

            //Pergunta para o usuário se ele confirma a exclusão do cadastro
            DialogResult Resposta;
            Resposta = MessageBox.Show("Cofirmar Exclusão?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Resposta.Equals(DialogResult.No))

            {
                return;
            }

            //Instancia a classe de Negocio
            clTransportadoras clTransportadora = new clTransportadoras();

            //Variavel com a string de conexão com o banco
            clTransportadora.Banco = Properties.Settings.Default.conexaoDB;
            clTransportadora.traCodigo = Convert.ToInt32(txtCodigo.Text);
            clTransportadora.Excluir();

            //Atualiza a DataGridView
            Pesquisar();

            //Mensagem de Confirmação de Exclusão
            MessageBox.Show("Transportadora Excluida com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void dgvTransportadoras_DoubleClick(object sender, EventArgs e)
        {
            //Verifica se existe itens na grid
            if (dgvTransportadoras.RowCount == 0)
            {
                return;
            }

            //Carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clTransportadoras clTransportadora = new clTransportadoras();
            clTransportadora.Banco = Properties.Settings.Default.conexaoDB;
            clTransportadora.traCodigo = (Convert.ToInt32(dgvTransportadoras.CurrentRow.Cells[0].Value));
            drReader = clTransportadora.PesquisarCodigo();

            if (drReader.Read())
            {
                //Transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["traCodigo"].ToString();
                txtRazaoSocial.Text = drReader["traRazaoSocial"].ToString();
                txtNomeFantasia.Text = drReader["traNomeFantasia"].ToString();
                mskCNPJ.Text = drReader["traCNPJ"].ToString();
                txtEmail.Text = drReader["traEmail"].ToString();
                mskTelefone.Text = drReader["traTelefone"].ToString();
                mskTelefone2.Text = drReader["traTelefone2"].ToString();
                mskCEP.Text = drReader["traCEP"].ToString();
                txtEndereco.Text = drReader["traEndereco"].ToString();
                txtNumero.Text = drReader["traNumero"].ToString();
                txtBairro.Text = drReader["traBairro"].ToString();
                txtCidade.Text = drReader["traCidade"].ToString();
                cboEstado.Text = drReader["traEstado"].ToString();
                txtObservacao.Text = drReader["traOBS"].ToString();


                //Habilita o Frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = traDados;
                txtRazaoSocial.Focus();
            }

            drReader.Close();
        }
    }
}
