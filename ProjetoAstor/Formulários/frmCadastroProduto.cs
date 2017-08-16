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
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }
        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO FÁBRICA")
            {
                Campo = "proCodFabrica";
            }
            else if (cboOpcao.Text == "NOME")
            {
                Campo = "proNome";
            }
            else if (cboOpcao.Text == "CATEGORIA")
            {
                Campo = "proCategoria";
            }
            else if (cboOpcao.Text == "GRUPO")
            {
                Campo = "proGrupo";
            }
            else if (cboOpcao.Text == "MATERIAL")
            {
                Campo = "proMaterial";
            }
            else if (cboOpcao.Text == "FORNECEDOR")
            {
                Campo = "proFornecedor";
            }


            //Carrega o datagridview com os clientes cadastrados
            clProduto clProdutos = new clProduto();
            clProdutos.Banco = Properties.Settings.Default.conexaoDB;
            dgvProdutos.DataSource = clProdutos.Pesquisar(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;

        }

        private void Limpar()
        {
            //Limpa todos os campos do formulário
            foreach (Control ctrl in grpProdutos.Controls)
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

        /*---------------------------------------------------------------------------------------------------*/

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
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

        private void tstSalvar_Click(object sender, EventArgs e)
        {

            //Validação do Conteúdo 
            if (txtCodFabrica.Text == "")
            {
                errErro.SetError(lblCodFabrica, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblCodFabrica, "");
            }
            //
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
            if (txtCor.Text == "")
            {
                errErro.SetError(lblCor, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblCor, "");
            }
            //
            if (txtFornecedor.Text == "")
            {
                errErro.SetError(lblFornecedor, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblFornecedor, "");
            }
            //
            if (txtValorUnitario.Text == "")
            {
                errErro.SetError(lblValorUnitario, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblValorUnitario, "");
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
            clProduto clProdutos = new clProduto();

            //Carrega as Propriedades
            clProdutos.proCodFabrica = txtCodFabrica.Text;
            clProdutos.proNome = txtNome.Text;
            clProdutos.proDataCadastro = dtpDataCadastro.Text;
            clProdutos.proCategoria = cboCategoria.Text;
            clProdutos.proMaterial = cboMaterial.Text;
            clProdutos.proGrupo = cboGrupo.Text;
            clProdutos.proCor = txtCor.Text;
            clProdutos.proFornecedor = txtFornecedor.Text;
            clProdutos.proValorUnitario = txtValorUnitario.Text;
            clProdutos.proMinVenda = txtMinimoVenda.Text;
            clProdutos.proQtdeEstoque = txtQuantidadeEstoque.Text;

            //Variavel com a string de conexão com o banco de dados
            clProdutos.Banco = Properties.Settings.Default.conexaoDB;

            //Chama o método Gravar
            if (txtCodigo.Text == "")
            {
                clProdutos.Gravar();
                MessageBox.Show("Produto Incluido com Sucesso!", "Gravado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clProdutos.proCodigo = Convert.ToInt32(txtCodigo.Text);
                clProdutos.Alterar();
                MessageBox.Show("Produto Alterado com Sucesso!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clProduto clProduto = new clProduto();

            //Variavel com a string de conexão com o banco
            clProduto.Banco = Properties.Settings.Default.conexaoDB;
            clProduto.proCodigo = Convert.ToInt32(txtCodigo.Text);
            clProduto.Excluir();

            //Atualiza a DataGridView
            Pesquisar();

            //Mensagem de Confirmação de Exclusão
            MessageBox.Show("Produto Excluido com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            //Verifica se existe itens na grid
            if (dgvProdutos.RowCount == 0)
            {
                return;
            }

            //Carrega a tela com todos os dados do Produto
            SqlDataReader drReader;
            clProduto clProduto = new clProduto();
            clProduto.Banco = Properties.Settings.Default.conexaoDB;
            clProduto.proCodigo = (Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value));
            drReader = clProduto.PesquisarCodigo2();

            if (drReader.Read())
            {
                //Transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["proCodigo"].ToString();
                txtCodFabrica.Text = drReader["proCodFabrica"].ToString();
                txtNome.Text = drReader["proNome"].ToString();
                dtpDataCadastro.Text = drReader["proDataCadastro"].ToString();
                cboCategoria.Text = drReader["proCategoria"].ToString();
                cboMaterial.Text = drReader["proMaterial"].ToString();
                cboGrupo.Text = drReader["proGrupo"].ToString();
                txtCor.Text = drReader["proCor"].ToString();
                txtFornecedor.Text = drReader["proFornecedor"].ToString();
                txtValorUnitario.Text = drReader["proValorUnitario"].ToString();
                txtMinimoVenda.Text = drReader["proMinVenda"].ToString();
                txtQuantidadeEstoque.Text = drReader["proQtdeEstoque"].ToString();




                //Habilita o Frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = proDados;
                txtNome.Focus();
            }

            drReader.Close();
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            int numeroMovimento = Convert.ToInt32(txtMovimento.Text);
            int totalEstoque = 0;

            if (txtQuantidadeEstoque.Text == "")
            {
                txtQuantidadeEstoque.Text = "0";
            }
            if (radAdicionar.Checked == true)
            {
                totalEstoque = Convert.ToInt32(txtQuantidadeEstoque.Text) + numeroMovimento;
                txtQuantidadeEstoque.Text = Convert.ToString(totalEstoque);
            }
            if (radRetirar.Checked == true)
            {
                totalEstoque = Convert.ToInt32(txtQuantidadeEstoque.Text) - numeroMovimento;
                txtQuantidadeEstoque.Text = Convert.ToString(totalEstoque);
            }
        }

        private void radAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdicionar.Checked == true)
            {
                lblMovimentar.Text = "Adicionar (un.)";
            }
        }

        private void radRetirar_CheckedChanged(object sender, EventArgs e)
        {
            if (radRetirar.Checked == true)
            {
                lblMovimentar.Text = "Retirar (un.)";
            }
        }
    }
}
