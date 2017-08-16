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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }
        void Limpar()
        {
            //Limpa os TextBox
            //Name dos objetos do Formulário
            txtCodProduto.Text = "";
            txtNome.Text = "";
            txtValorUnitario.Text = "";
            txtQuantidade.Text = "";
            txtSubTotal.Text = "";
        }

        void LimparPedido()
        {
            //limpa os textbox's
            txtCodigo.Text = "";
            cboClientes.Text = "";
            txtCodProduto.Text = "";
            txtNome.Text = "";
            txtValorUnitario.Text = "";
            txtQuantidade.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";

            //limpa o grid de itens
            CarregarItens(0);
        }

        void SubTotal()
        {
            int Qtde;
            if (!int.TryParse(txtQuantidade.Text, out Qtde))
            {
                Qtde = 0;
            }

            //Verifica se o valor unitário é numerico
            decimal Unitario;
            if (!decimal.TryParse(txtValorUnitario.Text, out Unitario))
            {
                Unitario = 0;
            }

            //Calcula o SubTotal do Item
            txtSubTotal.Text = Convert.ToString(Qtde * Unitario);
        }

        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO")
            {
                Campo = "pedCodigo";
            }
            else if (cboOpcao.Text == "DATA")
            {
                Campo = "pedData";
            }
            else if (cboOpcao.Text == "CLIENTE")
            {
                Campo = "cliNome";
            }


            //Carrega o datagridview com os clientes cadastrados
            clPedido clPedido = new clPedido();
            clPedido.Banco = Properties.Settings.Default.conexaoDB;
            dgvPedidos.DataSource = clPedido.Pesquisar(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;

        }

        private void CarregarItens(int Pedido)
        {
            //Carrega o DataGridView com os itens do pedido
            clItensPedido clItensPedido = new clItensPedido();
            clItensPedido.Banco = Properties.Settings.Default.conexaoDB;
            dgvItens.DataSource = clItensPedido.Pesquisar(Pedido).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no DataGridView
            dgvItens.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;
        }

        private void TotalPedido()
        {
            SqlDataReader drReader;

            //Instancia a classe
            clItensPedido clItensPedido = new clItensPedido();
            clItensPedido.Banco = Properties.Settings.Default.conexaoDB;
            drReader = clItensPedido.TotalPedido(Convert.ToInt32(txtCodigo.Text));
            if (drReader.Read())
            {
                txtTotal.Text = drReader["Total"].ToString();
            }
            else
            {
                txtTotal.Text = "0,00";
            }
            drReader.Close();

        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            //variável do tipo dataReader
            SqlDataReader drReader;

            //instancia a classe de clientes
            clClientes clClientes = new clClientes();

            //passa a string de conexão para a classe de clientes
            clClientes.Banco = Properties.Settings.Default.conexaoDB;

            //carrega a lista de clientes
            drReader = clClientes.CarregarClientes();
            while (drReader.Read())
            {
                cboClientes.Items.Add(drReader["cliRazaoSocial"].ToString());
            }

            //fecha o dataReader
            drReader.Close();

            //chama o método pesquisar
            Pesquisar();
        }

        private void frmPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Envia o Tab quando for precionado o Enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //limpa a tela
            LimparPedido();
            cboClientes.Focus();
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            SqlDataReader drReader;

            //verifica se foi digitado alguma coisa
            if (txtCodProduto.Text == "")
            {
                Limpar();
                return;
            }

            //verifica se foi digitado número no código
            //do produto
            int codProd;
            if (!int.TryParse(txtCodProduto.Text, out codProd))
            {
                MessageBox.Show("Produto Inválido!", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Limpar();
                txtCodProduto.Focus();
                return;
            }

            //verifica se o produto está cadastrado
            clProduto clProdutos = new clProduto();
            clProdutos.Banco = Properties.Settings.Default.conexaoDB;
            drReader = clProdutos.PesquisarCodigo(Convert.ToInt32(txtCodProduto.Text));
            if (drReader.Read())
            {
                txtNome.Text = drReader["proNome"].ToString();
                txtValorUnitario.Text = drReader["proValorUnitario"].ToString();
            }
            else
            {
                Limpar();
                txtCodProduto.Focus();
            }
            drReader.Close();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            //Chama o Método SubTotal
            SubTotal();
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            //Chama o Método SubTotal
            SubTotal();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            SqlDataReader drReader;
            int cliCodigo = 0;

            //Verifica se o cliente foi selecionado 
            if (cboClientes.Text == "")
            {
                MessageBox.Show("Selecione o Cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboClientes.Focus();
                return;
            }

            //Verifica se o produto foi digitado
            if (txtNome.Text == "")
            {
                MessageBox.Show("Produto Invalido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProduto.Focus();
                return;
            }

            //Verifica se o SubTotal está Zerado
            if (txtSubTotal.Text == "0,00" || txtSubTotal.Text == "")
            {
                MessageBox.Show("SubTotal Inválido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //Instancia as Classes
            clClientes clClientes = new clClientes();
            clPedido clPedido = new clPedido();
            clItensPedido clItensPedido = new clItensPedido();

            //Verifica se o pedido ja foi salvo
            if (txtCodigo.Text == "")
            {
                //Perguntar para o Usuário se ele confirma a inclusão do Pedido
                DialogResult resposta;
                resposta = MessageBox.Show("Confirma a Inclusão do Pedido?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta.Equals(DialogResult.Yes))
                {
                    //Seleciona o Código do Cliente
                    clClientes.Banco = Properties.Settings.Default.conexaoDB;
                    drReader = clClientes.PesquisarNome(cboClientes.Text);
                    if (drReader.Read())
                    {
                        cliCodigo = Convert.ToInt32(drReader["cliCodigo"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Cliente Invalido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        drReader.Close();
                        return;
                    }
                    drReader.Close();

                    //Carrega as Propriedades do Pedido
                    clPedido.Banco = Properties.Settings.Default.conexaoDB;
                    clPedido.pedData = String.Format("{0:yyyy-MM-dd}", dtpData.Value);
                    clPedido.funNome = cboVendedor.Text;
                    clPedido.cliCodigo = cliCodigo;
                    txtCodigo.Text = Convert.ToString(clPedido.Gravar());

                    //Carrega as Propriedades do Item
                    clItensPedido.Banco = Properties.Settings.Default.conexaoDB;
                    clItensPedido.pedCodigo = Convert.ToInt32(txtCodigo.Text);
                    clItensPedido.proCodigo = Convert.ToInt32(txtCodProduto.Text);
                    clItensPedido.itmQtde = txtQuantidade.Text;
                    clItensPedido.itmUnitario = txtValorUnitario.Text;
                    clItensPedido.itmSubtotal = txtSubTotal.Text;
                    clItensPedido.Gravar();

                    //Atualiza a lista de itens inseridas
                    CarregarItens(Convert.ToInt32(txtCodigo.Text));

                    //Totaliza o Pedido
                    TotalPedido();

                    //Limpa os Campos
                    Limpar();
                    txtCodProduto.Focus();
                }
            }
            else
            {
                //Carrega as Propriedades do Item
                clItensPedido.Banco = Properties.Settings.Default.conexaoDB;
                clItensPedido.pedCodigo = Convert.ToInt32(txtCodigo.Text);
                clItensPedido.proCodigo = Convert.ToInt32(txtCodProduto.Text);
                clItensPedido.itmQtde = txtQuantidade.Text;
                clItensPedido.itmUnitario = txtValorUnitario.Text;
                clItensPedido.itmSubtotal = txtSubTotal.Text;
                clItensPedido.Gravar();

                //Atualiza a lista de itens inseridas
                CarregarItens(Convert.ToInt32(txtCodigo.Text));

                //Totaliza o Pedido
                TotalPedido();

                //Limpa os Campos
                Limpar();
                txtCodProduto.Focus();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void tstExcluir_Click(object sender, EventArgs e)
        {
            //verifica se existe o código do pedido
            if (txtCodigo.Text != "")
            {
                //pergunta para o usuário se ele confirma a inclusão do pedido
                DialogResult resposta;
                resposta = MessageBox.Show("Confirma a Exclusão do Pedido?",
                    "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (resposta.Equals(DialogResult.Yes))
                {
                    //seleciona o código do cliente
                    clPedido clPedidos = new clPedido();
                    clPedidos.Banco = Properties.Settings.Default.conexaoDB;
                    clPedidos.pedCodigo = Convert.ToInt32(txtCodigo.Text);
                    clPedidos.Excluir();

                    //limpa a tela
                    LimparPedido();
                    Pesquisar();
                    cboClientes.Focus();
                }
            }
        }

        private void dgvItens_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvPedidos.RowCount == 0)
            {
                return;
            }

            //pergunta para o usuário se ele confirma a exclusão do ítem
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a Exclusão do Ítem?","Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.Yes))
            {
                //seleciona o código do cliente
                clItensPedido clItensPedido = new clItensPedido();
                clItensPedido.Banco = Properties.Settings.Default.conexaoDB;
                clItensPedido.itmCodigo = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value);
                clItensPedido.Excluir();

                //totaliza o pedido
                TotalPedido();
            }
            else
            {
                //cancela a exclusão
                e.Cancel = true;
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            //verifica se existe itens na grid
            if (dgvPedidos.RowCount == 0)
            {
                return;
            }

            //carrega a tela com todos os dados do pedido
            SqlDataReader drReader;
            clPedido clPedidos = new clPedido();
            clPedidos.Banco = Properties.Settings.Default.conexaoDB;
            drReader = clPedidos.Pesquisar((Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value)));
            if (drReader.Read())
            {
                //transfere os dados do banco de dados para os campos
                //do formulário
                txtCodigo.Text = drReader["pedCodigo"].ToString();
                dtpData.Text = drReader["pedData"].ToString();
                cboVendedor.Text = drReader["funNome"].ToString();
                cboClientes.Text = drReader["Cliente"].ToString();

                //seleciona a aba de cadastro e posiciona o cursor no campo nome
                tabControl1.SelectedTab = tabDadosPedido;
                cboClientes.Focus();

                //carrega os itens do pedido
                CarregarItens(Convert.ToInt32(txtCodigo.Text));

                //totaliza o pedido
                TotalPedido();
            }
            drReader.Close();
        }
    }
}
