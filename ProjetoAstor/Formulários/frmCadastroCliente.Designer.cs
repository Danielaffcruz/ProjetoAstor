namespace ProjetoAstor
{
    partial class frmCadastroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.cliPesquisar = new System.Windows.Forms.TabPage();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblInsEstadual = new System.Windows.Forms.Label();
            this.mskInsEstadual = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.ckbFisica = new System.Windows.Forms.RadioButton();
            this.ckbJuridica = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.cliPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabDados.SuspendLayout();
            this.grpClientes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstNovo,
            this.tstSalvar,
            this.tstExcluir,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1251, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstNovo
            // 
            this.tstNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstNovo.Image = global::ProjetoAstor.Properties.Resources._838_32x32;
            this.tstNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstNovo.Name = "tstNovo";
            this.tstNovo.Size = new System.Drawing.Size(84, 36);
            this.tstNovo.Text = "&Novo";
            this.tstNovo.ToolTipText = "Novo Cadastro";
            this.tstNovo.Click += new System.EventHandler(this.tstNovo_Click);
            // 
            // tstSalvar
            // 
            this.tstSalvar.DoubleClickEnabled = true;
            this.tstSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstSalvar.Image = global::ProjetoAstor.Properties.Resources._8439_32x32;
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(93, 36);
            this.tstSalvar.Text = "&Salvar ";
            this.tstSalvar.ToolTipText = "Salvar Cliente";
            this.tstSalvar.Click += new System.EventHandler(this.tstSalvar_Click);
            // 
            // tstExcluir
            // 
            this.tstExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstExcluir.Image = global::ProjetoAstor.Properties.Resources._7943_32x32;
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(91, 36);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.ToolTipText = "Excluir Cliente";
            this.tstExcluir.Click += new System.EventHandler(this.tstExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tstSair
            // 
            this.tstSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstSair.Image = global::ProjetoAstor.Properties.Resources._7884_32x32;
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(73, 36);
            this.tstSair.Text = "S&air";
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click_1);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // cliPesquisar
            // 
            this.cliPesquisar.Controls.Add(this.dgvClientes);
            this.cliPesquisar.Controls.Add(this.txtFiltro);
            this.cliPesquisar.Controls.Add(this.lblFiltro);
            this.cliPesquisar.Controls.Add(this.cboOpcao);
            this.cliPesquisar.Controls.Add(this.lblOpcao);
            this.cliPesquisar.Location = new System.Drawing.Point(4, 25);
            this.cliPesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cliPesquisar.Name = "cliPesquisar";
            this.cliPesquisar.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cliPesquisar.Size = new System.Drawing.Size(1217, 425);
            this.cliPesquisar.TabIndex = 1;
            this.cliPesquisar.Text = "Pesquisar";
            this.cliPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(9, 16);
            this.lblOpcao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(128, 16);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Opção de Pesquisa";
            // 
            // cboOpcao
            // 
            this.cboOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "CÓDIGO",
            "RAZÃO SOCIAL/NOME",
            "NOME FANTASIA/SOBRENOME",
            "CNPJ/CPF",
            "INS. ESTADUAL/RG",
            "PESSOA FÍSICA",
            "PESSOA JURÍDICA"});
            this.cboOpcao.Location = new System.Drawing.Point(13, 39);
            this.cboOpcao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(207, 24);
            this.cboOpcao.TabIndex = 1;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(271, 16);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(275, 39);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(934, 22);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.dgvClientes.Location = new System.Drawing.Point(8, 73);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1201, 343);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.grpClientes);
            this.tabDados.Location = new System.Drawing.Point(4, 25);
            this.tabDados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDados.Size = new System.Drawing.Size(1217, 425);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados do Cliente";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.ckbJuridica);
            this.grpClientes.Controls.Add(this.ckbFisica);
            this.grpClientes.Controls.Add(this.mskTelefone2);
            this.grpClientes.Controls.Add(this.label1);
            this.grpClientes.Controls.Add(this.txtNomeFantasia);
            this.grpClientes.Controls.Add(this.btnPesquisar);
            this.grpClientes.Controls.Add(this.lblObservacao);
            this.grpClientes.Controls.Add(this.txtObservacao);
            this.grpClientes.Controls.Add(this.lblSite);
            this.grpClientes.Controls.Add(this.txtSite);
            this.grpClientes.Controls.Add(this.lblEmail);
            this.grpClientes.Controls.Add(this.txtEmail);
            this.grpClientes.Controls.Add(this.mskCelular);
            this.grpClientes.Controls.Add(this.lblCelular);
            this.grpClientes.Controls.Add(this.mskTelefone);
            this.grpClientes.Controls.Add(this.lblTelefone);
            this.grpClientes.Controls.Add(this.cboEstado);
            this.grpClientes.Controls.Add(this.lblEstado);
            this.grpClientes.Controls.Add(this.lblCidade);
            this.grpClientes.Controls.Add(this.txtCidade);
            this.grpClientes.Controls.Add(this.lblBairro);
            this.grpClientes.Controls.Add(this.txtBairro);
            this.grpClientes.Controls.Add(this.lblNumero);
            this.grpClientes.Controls.Add(this.txtNumero);
            this.grpClientes.Controls.Add(this.lblEndereco);
            this.grpClientes.Controls.Add(this.txtEndereco);
            this.grpClientes.Controls.Add(this.mskCEP);
            this.grpClientes.Controls.Add(this.lblCEP);
            this.grpClientes.Controls.Add(this.mskInsEstadual);
            this.grpClientes.Controls.Add(this.lblInsEstadual);
            this.grpClientes.Controls.Add(this.mskCNPJ);
            this.grpClientes.Controls.Add(this.lblCNPJ);
            this.grpClientes.Controls.Add(this.lblNomeFantasia);
            this.grpClientes.Controls.Add(this.lblRazaoSocial);
            this.grpClientes.Controls.Add(this.txtRazaoSocial);
            this.grpClientes.Controls.Add(this.txtCodigo);
            this.grpClientes.Controls.Add(this.lblCodigo);
            this.grpClientes.Location = new System.Drawing.Point(9, 0);
            this.grpClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpClientes.Size = new System.Drawing.Size(1197, 412);
            this.grpClientes.TabIndex = 0;
            this.grpClientes.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(13, 80);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 103);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(192, 41);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(473, 22);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(187, 20);
            this.lblRazaoSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(89, 16);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(699, 17);
            this.lblNomeFantasia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(100, 16);
            this.lblNomeFantasia.TabIndex = 5;
            this.lblNomeFantasia.Text = "Nome Fantásia";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(187, 80);
            this.lblCNPJ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(43, 16);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(191, 103);
            this.mskCNPJ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(143, 22);
            this.mskCNPJ.TabIndex = 5;
            // 
            // lblInsEstadual
            // 
            this.lblInsEstadual.AutoSize = true;
            this.lblInsEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsEstadual.Location = new System.Drawing.Point(371, 80);
            this.lblInsEstadual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInsEstadual.Name = "lblInsEstadual";
            this.lblInsEstadual.Size = new System.Drawing.Size(91, 16);
            this.lblInsEstadual.TabIndex = 14;
            this.lblInsEstadual.Text = "Insc. Estadual";
            // 
            // mskInsEstadual
            // 
            this.mskInsEstadual.Location = new System.Drawing.Point(375, 103);
            this.mskInsEstadual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskInsEstadual.Mask = "000,000,00-0";
            this.mskInsEstadual.Name = "mskInsEstadual";
            this.mskInsEstadual.Size = new System.Drawing.Size(95, 22);
            this.mskInsEstadual.TabIndex = 6;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(1053, 80);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 16);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(1057, 103);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(83, 22);
            this.mskCEP.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(17, 175);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(452, 22);
            this.txtEndereco.TabIndex = 10;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(13, 150);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(501, 175);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(109, 22);
            this.txtNumero.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(496, 150);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 16);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Número";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(645, 175);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(199, 22);
            this.txtBairro.TabIndex = 12;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(641, 150);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 16);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(865, 175);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(220, 22);
            this.txtCidade.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(861, 150);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(1107, 150);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR ",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(1111, 175);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboEstado.MaxLength = 2;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(77, 24);
            this.cboEstado.TabIndex = 14;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 215);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(72, 16);
            this.lblTelefone.TabIndex = 28;
            this.lblTelefone.Text = "Telefone 1";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(17, 239);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(103, 22);
            this.mskTelefone.TabIndex = 15;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(357, 215);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 16);
            this.lblCelular.TabIndex = 30;
            this.lblCelular.Text = "Celular";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(360, 239);
            this.mskCelular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(109, 22);
            this.mskCelular.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(535, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(489, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(531, 80);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(501, 239);
            this.txtSite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSite.MaxLength = 50;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(687, 22);
            this.txtSite.TabIndex = 18;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(496, 215);
            this.lblSite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(34, 16);
            this.lblSite.TabIndex = 35;
            this.lblSite.Text = "Site ";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(16, 294);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1171, 105);
            this.txtObservacao.TabIndex = 19;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(13, 274);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 16);
            this.lblObservacao.TabIndex = 37;
            this.lblObservacao.Text = "Observação";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(1157, 100);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 30);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(703, 41);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeFantasia.MaxLength = 100;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(485, 22);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Telefone 2";
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(191, 239);
            this.mskTelefone2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskTelefone2.Mask = "(00)0000-0000";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(103, 22);
            this.mskTelefone2.TabIndex = 16;
            // 
            // ckbFisica
            // 
            this.ckbFisica.AutoSize = true;
            this.ckbFisica.Location = new System.Drawing.Point(19, 22);
            this.ckbFisica.Name = "ckbFisica";
            this.ckbFisica.Size = new System.Drawing.Size(112, 20);
            this.ckbFisica.TabIndex = 47;
            this.ckbFisica.TabStop = true;
            this.ckbFisica.Text = "Pessoa Física";
            this.ckbFisica.UseVisualStyleBackColor = true;
            this.ckbFisica.CheckedChanged += new System.EventHandler(this.ckbFisica_CheckedChanged_1);
            // 
            // ckbJuridica
            // 
            this.ckbJuridica.AutoSize = true;
            this.ckbJuridica.Location = new System.Drawing.Point(19, 48);
            this.ckbJuridica.Name = "ckbJuridica";
            this.ckbJuridica.Size = new System.Drawing.Size(123, 20);
            this.ckbJuridica.TabIndex = 48;
            this.ckbJuridica.TabStop = true;
            this.ckbJuridica.Text = "Pessoa Jurídica";
            this.ckbJuridica.UseVisualStyleBackColor = true;
            this.ckbJuridica.CheckedChanged += new System.EventHandler(this.ckbJuridica_CheckedChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.cliPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(16, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 454);
            this.tabControl1.TabIndex = 3;
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 522);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::CADASTRO DE CLIENTE:::.";
            this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadastroClientes_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.cliPesquisar.ResumeLayout(false);
            this.cliPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstNovo;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.RadioButton ckbJuridica;
        private System.Windows.Forms.RadioButton ckbFisica;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskInsEstadual;
        private System.Windows.Forms.Label lblInsEstadual;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage cliPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
    }
}