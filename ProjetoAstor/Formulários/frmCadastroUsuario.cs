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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        void Pesquisar()
        {
            string Campo = "";

            //Seleciona o campo de pesquisa
            if (cboOpcao.Text == "SOBRENOME")
            {
                Campo = "usuSobrenome";
            }
            else if (cboOpcao.Text == "NOME")
            {
                Campo = "usuNome";
            }
            else if (cboOpcao.Text == "USUÁRIO")
            {
                Campo = "usuUsuario";
            }

            //Carrega o datagridview com os clientes cadastrados
            clUsuarios clUsuarios = new clUsuarios();
            clUsuarios.Banco = Properties.Settings.Default.conexaoDB;
            dgvUsuario.DataSource = clUsuarios.PesquisarData(Campo, txtFiltro.Text).Tables[0];

            //Comando utilizado para gerar um efeito "Zebrado" no datagridview
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;

        }

        private void Limpar()
        {
            //Limpa todos os campos do formulário
            foreach (Control ctrl in grpUsuarios.Controls)
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

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void frmCadastroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Envia o Tab quando for precionado o Enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
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
            //Validação do Conteúdo 
            if (txtUsuario.Text == "")
            {
                errErro.SetError(lblUsuario, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblUsuario, "");
            }

            //Validação do Conteúdo 
            if (txtSenha.Text == "")
            {
                errErro.SetError(lblSenha, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblSenha, "");
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
            clUsuarios clUsuario = new clUsuarios();

            //Carrega as Propriedades
            clUsuario.usrNome = txtNome.Text;
            clUsuario.usrSobrenome = txtSobrenome.Text;
            clUsuario.usrUsuario = txtUsuario.Text;
            clUsuario.usrSenha = txtSenha.Text;
            clUsuario.usrEmail = txtEmail.Text;
            if (ckbClientes.Checked == true)
            {
                clUsuario.usrPerClientes = "1";
            }

            else
            {
                clUsuario.usrPerClientes = "0";
            }

            if (ckbFuncionarios.Checked == true)
            {
                clUsuario.usrPerFuncionarios = "1";
            }

            else
            {
                clUsuario.usrPerFuncionarios = "0";
            }


            if (ckbProdutos.Checked == true)
            {
                clUsuario.usrPerProdutos = "1";
            }

            else
            {
                clUsuario.usrPerProdutos = "0";
            }

            if (ckbTransportadora.Checked == true)
            {
                clUsuario.usrPerTransportadoras = "1";
            }

            else
            {
                clUsuario.usrPerTransportadoras = "0";
            }

            if (ckbUsuarios.Checked == true)
            {
                clUsuario.usrPerUsuarios = "1";
            }

            else
            {
                clUsuario.usrPerUsuarios = "0";
            }

            if (ckbPedidos.Checked == true)
            {
                clUsuario.usrPerPedidos = "1";
            }

            else
            {
                clUsuario.usrPerPedidos = "0";
            }

            //Variavel com a string de conexão com o banco de dados
            clUsuario.Banco = Properties.Settings.Default.conexaoDB;

            //Chama o método Gravar
            if (txtCodigo.Text == "")
            {
                clUsuario.Gravar();
                MessageBox.Show("Usuário Incluido com Sucesso!", "Gravado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clUsuario.usrCodigo = Convert.ToInt32(txtCodigo.Text);
                clUsuario.Alterar();
                MessageBox.Show("Usuário Alterado com Sucesso!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Atualiza o DataGridView
            Pesquisar();

            Limpar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void dgvUsuario_DoubleClick(object sender, EventArgs e)
        {
            //Verifica se existe itens na grid
            if (dgvUsuario.RowCount == 0)
            {
                return;
            }

            //Carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clUsuarios clUsuario = new clUsuarios();
            clUsuario.Banco = Properties.Settings.Default.conexaoDB;
            clUsuario.usrCodigo = (Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value));
            drReader = clUsuario.PesquisarReader2();

            if (drReader.Read())
            {
                //Transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["usuCodigo"].ToString();
                txtNome.Text = drReader["usuNome"].ToString();
                txtSobrenome.Text = drReader["usuSobrenome"].ToString();
                txtUsuario.Text = drReader["usuUsuario"].ToString();
                txtSenha.Text = drReader["usuSenha"].ToString();
                txtEmail.Text = drReader["usuEmail"].ToString();

                if (Convert.ToBoolean(drReader["usuClientes"].ToString()) == true)
                {
                    ckbClientes.Checked = true;
                }
                else
                {
                    ckbClientes.Checked = false;
                }

                if (Convert.ToBoolean(drReader["usuFuncionarios"].ToString()) == true)
                {
                    ckbFuncionarios.Checked = true;
                }
                else
                {
                    ckbFuncionarios.Checked = false;
                }

                if (Convert.ToBoolean(drReader["usuProdutos"].ToString()) == true)
                {
                    ckbProdutos.Checked = true;
                }
                else
                {
                    ckbProdutos.Checked = false;
                }

                if (Convert.ToBoolean(drReader["usuUsuarios"].ToString()) == true)
                {
                    ckbUsuarios.Checked = true;
                }
                else
                {
                    ckbUsuarios.Checked = false;
                }


                if (Convert.ToBoolean(drReader["usuPedidos"].ToString()) == true)
                {
                    ckbPedidos.Checked = true;
                }
                else
                {
                    ckbPedidos.Checked = false;
                }

                //Habilita o Frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = usuDados;
                txtNome.Focus();
            }

            drReader.Close();
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
            clUsuarios clUsuario = new clUsuarios();
            
            //Variavel com a string de conexão com o banco
            clUsuario.Banco = Properties.Settings.Default.conexaoDB;
            clUsuario.usrCodigo = Convert.ToInt32(txtCodigo.Text);
            clUsuario.Excluir();

            //Atualiza a DataGridView
            Pesquisar();

            //Mensagem de Confirmação de Exclusão
            MessageBox.Show("Usuário Excluido com Sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
