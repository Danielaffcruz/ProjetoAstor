using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace ProjetoAstor.Formulários
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Clientes;
            bool Funcionarios;
            bool Produtos;
            bool Transportadoras;
            bool Usuarios;
            bool Pedidos;
            


            //Verifica se o Usuário foi Digitado
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Nome de Usuário Invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            //Verifica se a Senha foi Digitada
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha Invalida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }

            //Verifica se o usuário e senha existem no banco de dados
            SqlDataReader drReader;
            clUsuarios clUsuario = new clUsuarios();
            clUsuario.Banco = Properties.Settings.Default.conexaoDB;
            drReader = clUsuario.PesquisarReader(txtUsuario.Text, txtSenha.Text);
            if (!drReader.Read())

            {
                MessageBox.Show("Acesso Negado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Verifica a Permissão de Acesso ao Usuário
                if (Convert.ToBoolean(drReader["usuClientes"].ToString()) == true)
                {
                    Clientes = true;
                }
                else
                {
                    Clientes = false;
                }
                if (Convert.ToBoolean(drReader["usuFuncionarios"].ToString()) == true)
                {
                    Funcionarios = true;
                }
                else
                {
                    Funcionarios = false;
                }
                if (Convert.ToBoolean(drReader["usuProdutos"].ToString()) == true)
                {
                    Produtos = true;
                }
                else
                {
                    Produtos = false;
                }
                if (Convert.ToBoolean(drReader["usuTransportadoras"].ToString()) == true)
                {
                    Transportadoras = true;
                }
                else
                {
                    Transportadoras = false;
                }
                if (Convert.ToBoolean(drReader["usuUsuarios"].ToString()) == true)
                {
                    Usuarios = true;
                }
                else
                {
                    Usuarios = false;
                }

                if (Convert.ToBoolean(drReader["usuPedidos"].ToString()) == true)
                {
                    Pedidos = true;
                }
                else
                {
                    Pedidos = false;
                }

                //Oculta o formulário de Login 
                Hide();

                //Cria a instancia para abrir o formulario principal
                frmPrincipal frmPrincipal = new frmPrincipal();

                //transfere as Permissões de Acesso para o form Principal
                frmPrincipal.Clientes = Clientes;
                frmPrincipal.Funcionarios = Funcionarios;
                frmPrincipal.Produtos = Produtos;
                frmPrincipal.Transportadora = Transportadoras;
                frmPrincipal.Usuarios = Usuarios;
                frmPrincipal.Pedidos = Pedidos;
                
                //Abre o Formulário Principal
                frmPrincipal.Show();
            }

            //Fecha o DataReader
            drReader.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
