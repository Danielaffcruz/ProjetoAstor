using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAstor.Formulários
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Desativa o Timer
            timer1.Enabled = false;

            //Oculta o forumlário de Splash
            Hide();

            //Cria a instancia do formulário de login
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Muda o ponteiro do mouse
            UseWaitCursor = true;
        }
    }
}
