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

namespace ProjetoAstor
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO")
            {
                Campo = "funCodigo";
            }
            else if (cboOpcao.Text == "NOME")
            {
                Campo = "funNome";
            }
            else if (cboOpcao.Text == "SOBRENOME")
            {
                Campo = "funSobrenome";
            }
            else if (cboOpcao.Text == "CPF")
            {
                Campo = "funCPF";
            }
            else if (cboOpcao.Text == "E-MAIL")
            {
                Campo = "funEmail";
            }
            else if (cboOpcao.Text == "REMUNERAÇÃO")
            {
                Campo = "funRemuneracao";
            }
            else if (cboOpcao.Text == "VENDEDOR")
            {
                Campo = "funVendedor";
            }
            else if (cboOpcao.Text == "GERAL/OUTROS")
            {
                Campo = "funOutros";
            }


            //Carrega o datagridview com os clientes cadastrados
            clFuncionarios clFuncionarios = new clFuncionarios();
            clFuncionarios.Banco = Properties.Settings.Default.conexaoDB;
            dgvFuncionarios.DataSource = clFuncionarios.Pesquisar(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;

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
            foreach (Control ctrl in grpFuncionarios.Controls)
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

        /*------------------------------------------------------------------------------------*/

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCEP(mskCEP.Text);
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            string valor = mskCPF.Text;
            string mensagem = "";
            if (ValidacaoCPF.IsCpf(valor))
            {
                mensagem = "O número é um CPF Válido !";
            }
            else
            {
                mensagem = "O número é um CPF Inválido !";
            }
            MessageBox.Show(mensagem, "Validação");

            //Validação do Conteúdo 
            if (txtNome.Text == "")
            {
                errErro.SetError(lblNome, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblNome, "");
            }
            //
            if (txtSobrenome.Text == "")
            {
                errErro.SetError(lblSobrenome, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblSobrenome, "");
            }
            //
            if (mskRemuneracao.Text == "")
            {
                errErro.SetError(lblRemuneracao, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblRemuneracao, "");
            }
            //
            if (mskCPF.Text == "")
            {
                errErro.SetError(lblCPF, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblCPF, "");
            }
            //
            if (txtEmail.Text == "")
            {
                errErro.SetError(lblEmail, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblEmail, "");
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
            clFuncionarios clFuncionarios = new clFuncionarios();

            //Carrega as Propriedades
            if (ckbVendedor.Checked == true)
            {
                clFuncionarios.funVendedor = "1";
            }

            else
            {
                clFuncionarios.funVendedor = "0";
            }
            if (ckbOutros.Checked == true)
            {
                clFuncionarios.funOutros = "1";
            }

            else
            {
                clFuncionarios.funOutros = "0";
            }
            clFuncionarios.funNome = txtNome.Text;
            clFuncionarios.funSobrenome = txtSobrenome.Text;
            clFuncionarios.funRemuneracao = mskRemuneracao.Text;
            clFuncionarios.funCPF = mskCPF.Text;
            clFuncionarios.funRG = mskRG.Text;
            clFuncionarios.funEmail = txtEmail.Text;
            clFuncionarios.funCEP = mskCEP.Text;
            clFuncionarios.funEndereco = txtEndereco.Text;
            clFuncionarios.funNumero = txtNumero.Text;
            clFuncionarios.funBairro = txtBairro.Text;
            clFuncionarios.funCidade = txtCidade.Text;
            clFuncionarios.funEstado = cboEstado.Text;
            clFuncionarios.funTelefone = mskTelefone.Text;
            clFuncionarios.funCelular = mskCelular.Text;
            clFuncionarios.funObservacao = txtObservacao.Text;

            //Variavel com a string de conexão com o banco de dados
            clFuncionarios.Banco = Properties.Settings.Default.conexaoDB;

            //Chama o método Gravar
            if (txtCodigo.Text == "")
            {
                clFuncionarios.Gravar();
                MessageBox.Show("Funcionário Incluido com Sucesso!", "Gravado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clFuncionarios.funCodigo = Convert.ToInt32(txtCodigo.Text);
                clFuncionarios.Alterar();
                MessageBox.Show("Funcionário Alterado com Sucesso!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clFuncionarios clFuncionarios = new clFuncionarios();

            //Variavel com a string de conexão com o banco
            clFuncionarios.Banco = Properties.Settings.Default.conexaoDB;
            clFuncionarios.funCodigo = Convert.ToInt32(txtCodigo.Text);
            clFuncionarios.Excluir();

            //Atualiza a DataGridView
            Pesquisar();

            //Mensagem de Confirmação de Exclusão
            MessageBox.Show("Funcionário Excluido com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void dgvFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            //Verifica se existe itens na grid
            if (dgvFuncionarios.RowCount == 0)
            {
                return;
            }

            //Carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clFuncionarios clFuncionarios = new clFuncionarios();
            clFuncionarios.Banco = Properties.Settings.Default.conexaoDB;
            clFuncionarios.funCodigo = (Convert.ToInt32(dgvFuncionarios.CurrentRow.Cells[0].Value));
            drReader = clFuncionarios.PesquisarCodigo();

            if (drReader.Read())
            {
                //Transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["funCodigo"].ToString();
                txtNome.Text = drReader["funNome"].ToString();
                txtSobrenome.Text = drReader["funSobrenome"].ToString();
                mskRemuneracao.Text = drReader["funRemuneracao"].ToString();
                mskCPF.Text = drReader["funCPF"].ToString();
                mskRG.Text = drReader["funRG"].ToString();
                txtEmail.Text = drReader["funEmail"].ToString();
                mskCEP.Text = drReader["funCEP"].ToString();
                txtEndereco.Text = drReader["funEndereco"].ToString();
                txtNumero.Text = drReader["funNumero"].ToString();
                txtBairro.Text = drReader["funBairro"].ToString();
                txtCidade.Text = drReader["funCidade"].ToString();
                cboEstado.Text = drReader["funEstado"].ToString();
                mskTelefone.Text = drReader["funTelefone"].ToString();
                mskCelular.Text = drReader["funCelular"].ToString();
                txtObservacao.Text = drReader["funOBS"].ToString();

                if (Convert.ToBoolean(drReader["funVendedor"].ToString()) == true)
                {
                    ckbVendedor.Checked = true;
                }
                else
                {
                    ckbVendedor.Checked = false;
                }

                if (Convert.ToBoolean(drReader["funOutros"].ToString()) == true)
                {
                    ckbOutros.Checked = true;
                }
                else
                {
                    ckbOutros.Checked = false;
                }


                //Habilita o Frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = funDados;
                txtNome.Focus();
            }

            drReader.Close();
        }


    }
}
