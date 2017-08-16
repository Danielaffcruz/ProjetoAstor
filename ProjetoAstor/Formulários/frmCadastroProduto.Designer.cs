namespace ProjetoAstor.Formulários
{
    partial class frmCadastroProduto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.proDados = new System.Windows.Forms.TabPage();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.lblMovimentarEstoque = new System.Windows.Forms.Label();
            this.radRetirar = new System.Windows.Forms.RadioButton();
            this.radAdicionar = new System.Windows.Forms.RadioButton();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.lblMovimentar = new System.Windows.Forms.Label();
            this.txtMovimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinimoVenda = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodFabrica = new System.Windows.Forms.Label();
            this.txtCodFabrica = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proPesquisar = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.proDados.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            this.proPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.proDados);
            this.tabControl1.Controls.Add(this.proPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(16, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1233, 359);
            this.tabControl1.TabIndex = 5;
            // 
            // proDados
            // 
            this.proDados.Controls.Add(this.grpProdutos);
            this.proDados.Location = new System.Drawing.Point(4, 27);
            this.proDados.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.proDados.Name = "proDados";
            this.proDados.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.proDados.Size = new System.Drawing.Size(1225, 328);
            this.proDados.TabIndex = 0;
            this.proDados.Text = "Dados do Produto";
            this.proDados.UseVisualStyleBackColor = true;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.txtValorUnitario);
            this.grpProdutos.Controls.Add(this.btnMovimentar);
            this.grpProdutos.Controls.Add(this.lblMovimentarEstoque);
            this.grpProdutos.Controls.Add(this.radRetirar);
            this.grpProdutos.Controls.Add(this.radAdicionar);
            this.grpProdutos.Controls.Add(this.txtQuantidadeEstoque);
            this.grpProdutos.Controls.Add(this.lblMovimentar);
            this.grpProdutos.Controls.Add(this.txtMovimento);
            this.grpProdutos.Controls.Add(this.label10);
            this.grpProdutos.Controls.Add(this.dtpDataCadastro);
            this.grpProdutos.Controls.Add(this.txtCor);
            this.grpProdutos.Controls.Add(this.lblCor);
            this.grpProdutos.Controls.Add(this.label8);
            this.grpProdutos.Controls.Add(this.label7);
            this.grpProdutos.Controls.Add(this.txtMinimoVenda);
            this.grpProdutos.Controls.Add(this.lblValorUnitario);
            this.grpProdutos.Controls.Add(this.lblFornecedor);
            this.grpProdutos.Controls.Add(this.txtFornecedor);
            this.grpProdutos.Controls.Add(this.cboMaterial);
            this.grpProdutos.Controls.Add(this.label4);
            this.grpProdutos.Controls.Add(this.cboGrupo);
            this.grpProdutos.Controls.Add(this.label3);
            this.grpProdutos.Controls.Add(this.cboCategoria);
            this.grpProdutos.Controls.Add(this.label2);
            this.grpProdutos.Controls.Add(this.lblNome);
            this.grpProdutos.Controls.Add(this.txtNome);
            this.grpProdutos.Controls.Add(this.lblCodFabrica);
            this.grpProdutos.Controls.Add(this.txtCodFabrica);
            this.grpProdutos.Controls.Add(this.txtCodigo);
            this.grpProdutos.Controls.Add(this.label1);
            this.grpProdutos.Location = new System.Drawing.Point(9, 10);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(1207, 310);
            this.grpProdutos.TabIndex = 82;
            this.grpProdutos.TabStop = false;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorUnitario.Location = new System.Drawing.Point(22, 241);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtValorUnitario.MaxLength = 30;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(106, 24);
            this.txtValorUnitario.TabIndex = 9;
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.Location = new System.Drawing.Point(1069, 225);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(118, 30);
            this.btnMovimentar.TabIndex = 113;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // lblMovimentarEstoque
            // 
            this.lblMovimentarEstoque.AutoSize = true;
            this.lblMovimentarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentarEstoque.Location = new System.Drawing.Point(610, 215);
            this.lblMovimentarEstoque.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMovimentarEstoque.Name = "lblMovimentarEstoque";
            this.lblMovimentarEstoque.Size = new System.Drawing.Size(138, 16);
            this.lblMovimentarEstoque.TabIndex = 111;
            this.lblMovimentarEstoque.Text = "Movimentar Estoque?";
            // 
            // radRetirar
            // 
            this.radRetirar.AutoSize = true;
            this.radRetirar.Location = new System.Drawing.Point(703, 240);
            this.radRetirar.Name = "radRetirar";
            this.radRetirar.Size = new System.Drawing.Size(70, 22);
            this.radRetirar.TabIndex = 94;
            this.radRetirar.TabStop = true;
            this.radRetirar.Text = "Retirar";
            this.radRetirar.UseVisualStyleBackColor = true;
            this.radRetirar.CheckedChanged += new System.EventHandler(this.radRetirar_CheckedChanged);
            // 
            // radAdicionar
            // 
            this.radAdicionar.AutoSize = true;
            this.radAdicionar.Location = new System.Drawing.Point(585, 239);
            this.radAdicionar.Name = "radAdicionar";
            this.radAdicionar.Size = new System.Drawing.Size(87, 22);
            this.radAdicionar.TabIndex = 93;
            this.radAdicionar.TabStop = true;
            this.radAdicionar.Text = "Adicionar";
            this.radAdicionar.UseVisualStyleBackColor = true;
            this.radAdicionar.CheckedChanged += new System.EventHandler(this.radAdicionar_CheckedChanged);
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(348, 241);
            this.txtQuantidadeEstoque.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtQuantidadeEstoque.MaxLength = 10;
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.ReadOnly = true;
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(133, 24);
            this.txtQuantidadeEstoque.TabIndex = 11;
            // 
            // lblMovimentar
            // 
            this.lblMovimentar.AutoSize = true;
            this.lblMovimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentar.Location = new System.Drawing.Point(813, 230);
            this.lblMovimentar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMovimentar.Name = "lblMovimentar";
            this.lblMovimentar.Size = new System.Drawing.Size(93, 16);
            this.lblMovimentar.TabIndex = 109;
            this.lblMovimentar.Text = "Adicionar (un.)";
            // 
            // txtMovimento
            // 
            this.txtMovimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMovimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMovimento.Location = new System.Drawing.Point(918, 225);
            this.txtMovimento.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMovimento.MaxLength = 100;
            this.txtMovimento.Name = "txtMovimento";
            this.txtMovimento.Size = new System.Drawing.Size(133, 24);
            this.txtMovimento.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(802, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 108;
            this.label10.Text = "Data Cadastro";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(805, 47);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(128, 24);
            this.dtpDataCadastro.TabIndex = 3;
            // 
            // txtCor
            // 
            this.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.Location = new System.Drawing.Point(652, 134);
            this.txtCor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCor.MaxLength = 20;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(171, 24);
            this.txtCor.TabIndex = 7;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(649, 110);
            this.lblCor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(29, 16);
            this.lblCor.TabIndex = 107;
            this.lblCor.Text = "Cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Qtde. Estoque (un.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "Min. Venda (un.)";
            // 
            // txtMinimoVenda
            // 
            this.txtMinimoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMinimoVenda.Location = new System.Drawing.Point(178, 241);
            this.txtMinimoVenda.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMinimoVenda.MaxLength = 10;
            this.txtMinimoVenda.Name = "txtMinimoVenda";
            this.txtMinimoVenda.Size = new System.Drawing.Size(126, 24);
            this.txtMinimoVenda.TabIndex = 10;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(21, 215);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(97, 16);
            this.lblValorUnitario.TabIndex = 104;
            this.lblValorUnitario.Text = "Valor Unit. (R$)";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(842, 110);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(78, 16);
            this.lblFornecedor.TabIndex = 103;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(847, 134);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFornecedor.MaxLength = 50;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(341, 24);
            this.txtFornecedor.TabIndex = 8;
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Items.AddRange(new object[] {
            "COURO SINTÉTICO",
            "COURO LEGÍTIMO",
            "PVC ",
            "ENCARTE ",
            "METAL ",
            "TECIDO",
            "PLÁSTICO"});
            this.cboMaterial.Location = new System.Drawing.Point(24, 134);
            this.cboMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(264, 26);
            this.cboMaterial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "Material";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "PORTA DOCUMENTO",
            "PORTA MANUAL",
            "PORTA CNH",
            "PORTA CARTÃO DE CRÉDITO",
            "PORTA PASSAPORTE",
            "PORTA BOLSA",
            "CHAVEIRO",
            "BLOCO DE ANOTAÇÕES",
            "CANETAS",
            "CANECAS",
            "SQUEEZE",
            "POWER BANK",
            "FONE DE OUVIDO",
            "KIT CHURRASCO"});
            this.cboGrupo.Location = new System.Drawing.Point(323, 134);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(296, 26);
            this.cboGrupo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Grupo";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "PRODUTO FINAL",
            "MATÉRIA PRIMA"});
            this.cboCategoria.Location = new System.Drawing.Point(970, 45);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.MaxLength = 50;
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(217, 26);
            this.cboCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(971, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(362, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 99;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(365, 49);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(404, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblCodFabrica
            // 
            this.lblCodFabrica.AutoSize = true;
            this.lblCodFabrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFabrica.Location = new System.Drawing.Point(164, 21);
            this.lblCodFabrica.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodFabrica.Name = "lblCodFabrica";
            this.lblCodFabrica.Size = new System.Drawing.Size(101, 16);
            this.lblCodFabrica.TabIndex = 98;
            this.lblCodFabrica.Text = "Codigo Fábrica";
            // 
            // txtCodFabrica
            // 
            this.txtCodFabrica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFabrica.Location = new System.Drawing.Point(167, 49);
            this.txtCodFabrica.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCodFabrica.MaxLength = 10;
            this.txtCodFabrica.Name = "txtCodFabrica";
            this.txtCodFabrica.Size = new System.Drawing.Size(145, 24);
            this.txtCodFabrica.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(24, 49);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(104, 24);
            this.txtCodigo.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Código";
            // 
            // proPesquisar
            // 
            this.proPesquisar.Controls.Add(this.dgvProdutos);
            this.proPesquisar.Controls.Add(this.txtFiltro);
            this.proPesquisar.Controls.Add(this.lblFiltro);
            this.proPesquisar.Controls.Add(this.cboOpcao);
            this.proPesquisar.Controls.Add(this.lblOpcao);
            this.proPesquisar.Location = new System.Drawing.Point(4, 27);
            this.proPesquisar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.proPesquisar.Name = "proPesquisar";
            this.proPesquisar.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.proPesquisar.Size = new System.Drawing.Size(1225, 328);
            this.proPesquisar.TabIndex = 1;
            this.proPesquisar.Text = "Pesquisar";
            this.proPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 78);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(1201, 242);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(460, 39);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(753, 24);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(457, 17);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboOpcao
            // 
            this.cboOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "CÓDIGO FÁBRICA",
            "NOME",
            "CATEGORIA",
            "GRUPO",
            "MATERIAL",
            "FORNECEDOR"});
            this.cboOpcao.Location = new System.Drawing.Point(22, 39);
            this.cboOpcao.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(346, 26);
            this.cboOpcao.TabIndex = 1;
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(19, 17);
            this.lblOpcao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(128, 16);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Opção de Pesquisa";
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1256, 39);
            this.toolStrip1.TabIndex = 8;
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
            this.tstSalvar.ToolTipText = "Salvar Produto";
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
            this.tstExcluir.ToolTipText = "Excluir Produto";
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
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 404);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::CADASTRO DE PRODUTO:::.";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.tabControl1.ResumeLayout(false);
            this.proDados.ResumeLayout(false);
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            this.proPesquisar.ResumeLayout(false);
            this.proPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage proDados;
        private System.Windows.Forms.TabPage proPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.Label lblMovimentarEstoque;
        private System.Windows.Forms.RadioButton radRetirar;
        private System.Windows.Forms.RadioButton radAdicionar;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.Label lblMovimentar;
        private System.Windows.Forms.TextBox txtMovimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinimoVenda;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodFabrica;
        private System.Windows.Forms.TextBox txtCodFabrica;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.TextBox txtValorUnitario;
    }
}