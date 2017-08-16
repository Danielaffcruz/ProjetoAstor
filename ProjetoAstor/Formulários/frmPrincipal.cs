using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAstor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Propriedades Estaticas 
        //Informações vindas de outro formulário

        public static Boolean Clientes { get; set; }
        public static Boolean Funcionarios { get; set; }
        public static Boolean Produtos { get; set; }
        public static Boolean Transportadora { get; set; }
        public static Boolean Usuarios { get; set; }
        public static Boolean Pedidos { get; set; }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroClientes = new frmCadastroClientes();
            frmCadastroClientes.MdiParent = this;
            frmCadastroClientes.Show();
        }

        private void mnuPedidos_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroPedidos = new ProjetoAstor.Formulários.frmPedido();
            frmCadastroPedidos.MdiParent = this;
            frmCadastroPedidos.Show();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroProdutos = new ProjetoAstor.Formulários.frmCadastroProduto();
            frmCadastroProdutos.MdiParent = this;
            frmCadastroProdutos.Show();
        }

        private void mnuTransportadoras_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroTransportadora = new ProjetoAstor.Formulários.frmCadastroTransportadora();
            frmCadastroTransportadora.MdiParent = this;
            frmCadastroTransportadora.Show();
        }

        private void mnuFuncionarios_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroFuncionarios = new frmCadastroFuncionario();
            frmCadastroFuncionarios.MdiParent = this;
            frmCadastroFuncionarios.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            //Abre o formulário Agenda
            //Utilizando formulário MDI 
            Form frmCadastroUsuario = new ProjetoAstor.Formulários.frmCadastroUsuario();
            frmCadastroUsuario.MdiParent = this;
            frmCadastroUsuario.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            //Desabilita os Menus
            if (Clientes == false)
            {
                mnuClientes.Enabled = false;
            }

            if (Funcionarios == false)
            {
                mnuFuncionarios.Enabled = false;
            }

            if (Produtos == false)
            {
                mnuProdutos.Enabled = false;
            }

            if (Transportadora == false)
            {
                mnuTransportadoras.Enabled = false;
            }

            if (Usuarios == false)
            {
                mnuUsuarios.Enabled = false;
            }

            if (Pedidos == false)
            {
                mnuPedidos.Enabled = false;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
