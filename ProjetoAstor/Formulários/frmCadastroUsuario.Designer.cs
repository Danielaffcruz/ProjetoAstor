namespace ProjetoAstor.Formulários
{
    partial class frmCadastroUsuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usuDados = new System.Windows.Forms.TabPage();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.ckbPedidos = new System.Windows.Forms.CheckBox();
            this.ckbUsuarios = new System.Windows.Forms.CheckBox();
            this.ckbTransportadora = new System.Windows.Forms.CheckBox();
            this.ckbProdutos = new System.Windows.Forms.CheckBox();
            this.ckbFuncionarios = new System.Windows.Forms.CheckBox();
            this.ckbClientes = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuPesquisar = new System.Windows.Forms.TabPage();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.usuDados.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            this.usuPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.tstSalvar,
            this.tstExcluir,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1102, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::ProjetoAstor.Properties.Resources._838_32x32;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 36);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.ToolTipText = "Novo Cadastro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.tstSalvar.ToolTipText = "Salvar Usuário";
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
            this.tstExcluir.ToolTipText = "Excluir Usuário";
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
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usuDados);
            this.tabControl1.Controls.Add(this.usuPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(18, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 379);
            this.tabControl1.TabIndex = 7;
            // 
            // usuDados
            // 
            this.usuDados.Controls.Add(this.grpUsuarios);
            this.usuDados.Location = new System.Drawing.Point(4, 29);
            this.usuDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuDados.Name = "usuDados";
            this.usuDados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuDados.Size = new System.Drawing.Size(1057, 346);
            this.usuDados.TabIndex = 0;
            this.usuDados.Text = "Dados do Usuário";
            this.usuDados.UseVisualStyleBackColor = true;
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.ckbPedidos);
            this.grpUsuarios.Controls.Add(this.ckbUsuarios);
            this.grpUsuarios.Controls.Add(this.ckbTransportadora);
            this.grpUsuarios.Controls.Add(this.ckbProdutos);
            this.grpUsuarios.Controls.Add(this.ckbFuncionarios);
            this.grpUsuarios.Controls.Add(this.ckbClientes);
            this.grpUsuarios.Controls.Add(this.label5);
            this.grpUsuarios.Controls.Add(this.label4);
            this.grpUsuarios.Controls.Add(this.txtEmail);
            this.grpUsuarios.Controls.Add(this.lblSenha);
            this.grpUsuarios.Controls.Add(this.txtSenha);
            this.grpUsuarios.Controls.Add(this.lblUsuario);
            this.grpUsuarios.Controls.Add(this.txtUsuario);
            this.grpUsuarios.Controls.Add(this.lblSobrenome);
            this.grpUsuarios.Controls.Add(this.txtSobrenome);
            this.grpUsuarios.Controls.Add(this.lblNome);
            this.grpUsuarios.Controls.Add(this.txtNome);
            this.grpUsuarios.Controls.Add(this.txtCodigo);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Location = new System.Drawing.Point(10, 11);
            this.grpUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuarios.Size = new System.Drawing.Size(1034, 325);
            this.grpUsuarios.TabIndex = 0;
            this.grpUsuarios.TabStop = false;
            // 
            // ckbPedidos
            // 
            this.ckbPedidos.AutoSize = true;
            this.ckbPedidos.Location = new System.Drawing.Point(804, 230);
            this.ckbPedidos.Name = "ckbPedidos";
            this.ckbPedidos.Size = new System.Drawing.Size(85, 24);
            this.ckbPedidos.TabIndex = 24;
            this.ckbPedidos.Text = "Pedidos";
            this.ckbPedidos.UseVisualStyleBackColor = true;
            // 
            // ckbUsuarios
            // 
            this.ckbUsuarios.AutoSize = true;
            this.ckbUsuarios.Location = new System.Drawing.Point(679, 230);
            this.ckbUsuarios.Name = "ckbUsuarios";
            this.ckbUsuarios.Size = new System.Drawing.Size(91, 24);
            this.ckbUsuarios.TabIndex = 23;
            this.ckbUsuarios.Text = "Usuários";
            this.ckbUsuarios.UseVisualStyleBackColor = true;
            // 
            // ckbTransportadora
            // 
            this.ckbTransportadora.AutoSize = true;
            this.ckbTransportadora.Location = new System.Drawing.Point(509, 230);
            this.ckbTransportadora.Name = "ckbTransportadora";
            this.ckbTransportadora.Size = new System.Drawing.Size(145, 24);
            this.ckbTransportadora.TabIndex = 22;
            this.ckbTransportadora.Text = "Transportadoras";
            this.ckbTransportadora.UseVisualStyleBackColor = true;
            // 
            // ckbProdutos
            // 
            this.ckbProdutos.AutoSize = true;
            this.ckbProdutos.Location = new System.Drawing.Point(394, 230);
            this.ckbProdutos.Name = "ckbProdutos";
            this.ckbProdutos.Size = new System.Drawing.Size(92, 24);
            this.ckbProdutos.TabIndex = 21;
            this.ckbProdutos.Text = "Produtos";
            this.ckbProdutos.UseVisualStyleBackColor = true;
            // 
            // ckbFuncionarios
            // 
            this.ckbFuncionarios.AutoSize = true;
            this.ckbFuncionarios.Location = new System.Drawing.Point(253, 230);
            this.ckbFuncionarios.Name = "ckbFuncionarios";
            this.ckbFuncionarios.Size = new System.Drawing.Size(119, 24);
            this.ckbFuncionarios.TabIndex = 20;
            this.ckbFuncionarios.Text = "Funcionários";
            this.ckbFuncionarios.UseVisualStyleBackColor = true;
            // 
            // ckbClientes
            // 
            this.ckbClientes.AutoSize = true;
            this.ckbClientes.Location = new System.Drawing.Point(121, 230);
            this.ckbClientes.Name = "ckbClientes";
            this.ckbClientes.Size = new System.Drawing.Size(85, 24);
            this.ckbClientes.TabIndex = 19;
            this.ckbClientes.Text = "Clientes";
            this.ckbClientes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Permissões de Acesso ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(568, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(286, 106);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 16);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(291, 132);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(248, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(9, 106);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 16);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuário ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(14, 132);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(705, 25);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(79, 16);
            this.lblSobrenome.TabIndex = 11;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(710, 51);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSobrenome.MaxLength = 50;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(302, 26);
            this.txtSobrenome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(183, 25);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(188, 51);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(498, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 51);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // usuPesquisar
            // 
            this.usuPesquisar.Controls.Add(this.dgvUsuario);
            this.usuPesquisar.Controls.Add(this.txtFiltro);
            this.usuPesquisar.Controls.Add(this.lblFiltro);
            this.usuPesquisar.Controls.Add(this.cboOpcao);
            this.usuPesquisar.Controls.Add(this.lblOpcao);
            this.usuPesquisar.Location = new System.Drawing.Point(4, 29);
            this.usuPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuPesquisar.Name = "usuPesquisar";
            this.usuPesquisar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuPesquisar.Size = new System.Drawing.Size(1057, 346);
            this.usuPesquisar.TabIndex = 1;
            this.usuPesquisar.Text = "Pesquisar";
            this.usuPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToOrderColumns = true;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 90);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(1030, 252);
            this.dgvUsuario.TabIndex = 9;
            this.dgvUsuario.DoubleClick += new System.EventHandler(this.dgvUsuario_DoubleClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(264, 52);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(778, 26);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(260, 23);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 16);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboOpcao
            // 
            this.cboOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "NOME",
            "SOBRENOME",
            "USUÁRIO"});
            this.cboOpcao.Location = new System.Drawing.Point(14, 52);
            this.cboOpcao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(191, 28);
            this.cboOpcao.TabIndex = 6;
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(9, 23);
            this.lblOpcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(128, 16);
            this.lblOpcao.TabIndex = 5;
            this.lblOpcao.Text = "Opção de Pesquisa";
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 470);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::CADASTRO DE USUÁRIO:::.";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadastroUsuario_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.usuDados.ResumeLayout(false);
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.usuPesquisar.ResumeLayout(false);
            this.usuPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usuDados;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.TabPage usuPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.CheckBox ckbPedidos;
        private System.Windows.Forms.CheckBox ckbUsuarios;
        private System.Windows.Forms.CheckBox ckbTransportadora;
        private System.Windows.Forms.CheckBox ckbProdutos;
        private System.Windows.Forms.CheckBox ckbFuncionarios;
        private System.Windows.Forms.CheckBox ckbClientes;
        private System.Windows.Forms.ErrorProvider errErro;
    }
}