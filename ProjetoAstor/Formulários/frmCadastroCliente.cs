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
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO")
            {
                Campo = "cliCodigo";
            }
            else if (cboOpcao.Text == "RAZÃO SOCIAL/NOME")
            {
                Campo = "cliRazaoSocial";
            }
            else if (cboOpcao.Text == "NOME FANTASIA/SOBRENOME")
            {
                Campo = "cliNomeFantasia";
            }
            else if (cboOpcao.Text == "CNPJ/CPF")
            {
                Campo = "cliCNPJ";
            }
            else if (cboOpcao.Text == "INS. ESTADUAL/RG")
            {
                Campo = "cliInsEsta";
            }
            else if (cboOpcao.Text == "PESSOA FÍSICA")
            {
                Campo = "cliFisica";
            }
            else if (cboOpcao.Text == "PESSOA JURÍDICA")
            {
                Campo = "cliJuridica";
            }


            //Carrega o datagridview com os clientes cadastrados
            clClientes clClientes = new clClientes();
            clClientes.Banco = ProjetoAstor.Properties.Settings.Default.conexaoDB;
            dgvClientes.DataSource = clClientes.Pesquisar(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;

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
            foreach (Control ctrl in grpClientes.Controls)
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

        /*-------------------------------------------------------------------------------------------------*/

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Chama o método pesquisar
            Pesquisar();
        }

        private void tstNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmCadastroClientes_KeyPress(object sender, KeyPressEventArgs e)
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
            if (ckbJuridica.Checked == true)
            {
                if (ValidacaoCNPJ.IsCnpj(valor))
                {
                    mensagem = "CNPJ Válido !";
                }
                else
                {
                    mensagem = "CNPJ Inválido !";
                }
                MessageBox.Show(mensagem, "Validação");
            }
            if (ckbFisica.Checked == true)
            {
                if (ValidacaoCPF.IsCpf(valor))
                {
                    mensagem = "CPF Válido !";
                }
                else
                {
                    mensagem = "CPF Inválido !";
                }
                MessageBox.Show(mensagem, "Validação");
            }


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
            clClientes clClientes = new clClientes();

            //Carrega as Propriedades
            if (ckbFisica.Checked == true)
            {
                clClientes.cliFisica = "1";
            }

            else
            {
                clClientes.cliFisica = "0";
            }
            if (ckbJuridica.Checked == true)
            {
                clClientes.cliJuridica = "1";
            }

            else
            {
                clClientes.cliJuridica = "0";
            }
            clClientes.cliRazaoSocial = txtRazaoSocial.Text;
            clClientes.cliNomeFantasia = txtNomeFantasia.Text;
            clClientes.cliCNPJ = mskCNPJ.Text;
            clClientes.cliInsEsta = mskInsEstadual.Text;
            clClientes.cliEmail = txtEmail.Text;
            clClientes.cliCEP = mskCEP.Text;
            clClientes.cliEndereco = txtEndereco.Text;
            clClientes.cliNumero = txtNumero.Text;
            clClientes.cliBairro = txtBairro.Text;
            clClientes.cliCidade = txtCidade.Text;
            clClientes.cliEstado = cboEstado.Text;
            clClientes.cliTelefone1 = mskTelefone.Text;
            clClientes.cliTelefone2 = mskTelefone2.Text;
            clClientes.cliCelular = mskCelular.Text;
            clClientes.cliSite = txtSite.Text;
            clClientes.cliObservacao = txtObservacao.Text;

            //Variavel com a string de conexão com o banco de dados
            clClientes.Banco = ProjetoAstor.Properties.Settings.Default.conexaoDB;

            //Chama o método Gravar
            if (txtCodigo.Text == "")
            {
                clClientes.Gravar();
                MessageBox.Show("Cliente Incluido com Sucesso!", "Gravado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clClientes.cliCodigo = Convert.ToInt32(txtCodigo.Text);
                clClientes.Alterar();
                MessageBox.Show("Cliente Alterado com Sucesso!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clClientes clClientes = new clClientes();

            //Variavel com a string de conexão com o banco
            clClientes.Banco = Properties.Settings.Default.conexaoDB;
            clClientes.cliCodigo = Convert.ToInt32(txtCodigo.Text);
            clClientes.Excluir();

            //Atualiza a DataGridView
            Pesquisar();

            //Mensagem de Confirmação de Exclusão
            MessageBox.Show("Cliente Excluido com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //Verifica se existe itens na grid
            if (dgvClientes.RowCount == 0)
            {
                return;
            }

            //Carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clClientes clClientes = new clClientes();
            clClientes.Banco = Properties.Settings.Default.conexaoDB;
            clClientes.cliCodigo = (Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
            drReader = clClientes.PesquisarCodigo();

            if (drReader.Read())
            {
                //Transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["cliCodigo"].ToString();
                txtRazaoSocial.Text = drReader["cliRazaoSocial"].ToString();
                txtNomeFantasia.Text = drReader["cliNomeFantasia"].ToString();
                mskCNPJ.Text = drReader["cliCNPJ"].ToString();
                mskInsEstadual.Text = drReader["cliInsEsta"].ToString();
                txtEmail.Text = drReader["cliEmail"].ToString();
                mskCEP.Text = drReader["cliCEP"].ToString();
                txtEndereco.Text = drReader["cliEndereco"].ToString();
                txtNumero.Text = drReader["cliNumero"].ToString();
                txtBairro.Text = drReader["cliBairro"].ToString();
                txtCidade.Text = drReader["cliCidade"].ToString();
                cboEstado.Text = drReader["cliEstado"].ToString();
                mskTelefone.Text = drReader["cliTelefone1"].ToString();
                mskTelefone2.Text = drReader["cliTelefone2"].ToString();
                mskCelular.Text = drReader["cliCelular"].ToString();
                txtSite.Text = drReader["cliSite"].ToString();
                txtObservacao.Text = drReader["cliOBS"].ToString();

                if (Convert.ToBoolean(drReader["cliFisica"].ToString()) == true)
                {
                    ckbFisica.Checked = true;
                }
                else
                {
                    ckbFisica.Checked = false;
                }

                if (Convert.ToBoolean(drReader["cliJuridica"].ToString()) == true)
                {
                    ckbJuridica.Checked = true;
                }
                else
                {
                    ckbJuridica.Checked = false;
                }


                //Habilita o Frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = tabDados;
                txtRazaoSocial.Focus();
            }

            drReader.Close();
        }

        private void tstSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbFisica_CheckedChanged_1(object sender, EventArgs e)
        {
            lblRazaoSocial.Text = "Nome";
            lblNomeFantasia.Text = "Sobrenome";
            lblInsEstadual.Text = "RG";
            lblCNPJ.Text = "CPF";
            mskCNPJ.Mask = "000,000,000-00";
            mskInsEstadual.Mask = "00,000,000-0";

        }

        private void ckbJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            lblRazaoSocial.Text = "Razão Social";
            lblNomeFantasia.Text = "Nome Fantásia";
            lblCNPJ.Text = "CNPJ";
            lblInsEstadual.Text = "Insc. Estadual";
            mskCNPJ.Mask = "00,000,000/0000-00";
            mskInsEstadual.Mask = "000,000,00-0";
        }
    }
}
