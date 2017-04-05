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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.proDados = new System.Windows.Forms.TabPage();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQntEstoque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodFabrica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.proDados.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            this.proPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 22);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.ToolTipText = "Clique para Salvar";
            // 
            // tstSalvar
            // 
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(45, 22);
            this.tstSalvar.Text = "&Salvar ";
            this.tstSalvar.ToolTipText = "Salvar Cliente";
            // 
            // tstExcluir
            // 
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(45, 22);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.ToolTipText = "Excluir Cliente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "S&air";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.proDados);
            this.tabControl1.Controls.Add(this.proPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 389);
            this.tabControl1.TabIndex = 4;
            // 
            // proDados
            // 
            this.proDados.Controls.Add(this.grpProdutos);
            this.proDados.Location = new System.Drawing.Point(4, 22);
            this.proDados.Name = "proDados";
            this.proDados.Padding = new System.Windows.Forms.Padding(3);
            this.proDados.Size = new System.Drawing.Size(717, 363);
            this.proDados.TabIndex = 0;
            this.proDados.Text = "Dados do Produto";
            this.proDados.UseVisualStyleBackColor = true;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.label11);
            this.grpProdutos.Controls.Add(this.txtComprimento);
            this.grpProdutos.Controls.Add(this.label10);
            this.grpProdutos.Controls.Add(this.txtLargura);
            this.grpProdutos.Controls.Add(this.label9);
            this.grpProdutos.Controls.Add(this.txtAltura);
            this.grpProdutos.Controls.Add(this.label8);
            this.grpProdutos.Controls.Add(this.txtQntEstoque);
            this.grpProdutos.Controls.Add(this.label7);
            this.grpProdutos.Controls.Add(this.cboMaterial);
            this.grpProdutos.Controls.Add(this.label6);
            this.grpProdutos.Controls.Add(this.txtMinVenda);
            this.grpProdutos.Controls.Add(this.label5);
            this.grpProdutos.Controls.Add(this.cboGrupo);
            this.grpProdutos.Controls.Add(this.label3);
            this.grpProdutos.Controls.Add(this.txtCor);
            this.grpProdutos.Controls.Add(this.label2);
            this.grpProdutos.Controls.Add(this.lblDescricao);
            this.grpProdutos.Controls.Add(this.txtDescricao);
            this.grpProdutos.Controls.Add(this.txtCodFabrica);
            this.grpProdutos.Controls.Add(this.label4);
            this.grpProdutos.Controls.Add(this.lblObservacao);
            this.grpProdutos.Controls.Add(this.txtObservacao);
            this.grpProdutos.Controls.Add(this.lblNome);
            this.grpProdutos.Controls.Add(this.txtNome);
            this.grpProdutos.Controls.Add(this.txtCodigo);
            this.grpProdutos.Controls.Add(this.label1);
            this.grpProdutos.Location = new System.Drawing.Point(7, 0);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(704, 357);
            this.grpProdutos.TabIndex = 0;
            this.grpProdutos.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Dimensões do Produto";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(213, 228);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(82, 20);
            this.txtComprimento.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(210, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Comprimento (cm)";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(335, 229);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(80, 20);
            this.txtLargura.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Largura (cm)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(447, 228);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(79, 20);
            this.txtAltura.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(444, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Altura (cm)";
            // 
            // txtQntEstoque
            // 
            this.txtQntEstoque.Location = new System.Drawing.Point(14, 205);
            this.txtQntEstoque.Name = "txtQntEstoque";
            this.txtQntEstoque.Size = new System.Drawing.Size(136, 20);
            this.txtQntEstoque.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Qnt. Estoque";
            // 
            // cboMaterial
            // 
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Items.AddRange(new object[] {
            "COURO SINTÊTICO",
            "COURO LÊGITIMO",
            "PVC",
            "METAL"});
            this.cboMaterial.Location = new System.Drawing.Point(335, 144);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(191, 21);
            this.cboMaterial.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Material";
            // 
            // txtMinVenda
            // 
            this.txtMinVenda.Location = new System.Drawing.Point(545, 144);
            this.txtMinVenda.Name = "txtMinVenda";
            this.txtMinVenda.Size = new System.Drawing.Size(144, 20);
            this.txtMinVenda.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Min. de Venda (un.) ";
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "PORTA DOCUMENTO",
            "PORTA CNH",
            "PORTA PASSAPORTE",
            "PORTA MANUAL",
            "CHAVEIRO",
            "SQUEEZE",
            "CANECA",
            "POWER BANK"});
            this.cboGrupo.Location = new System.Drawing.Point(165, 144);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(149, 21);
            this.cboGrupo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Grupo";
            // 
            // txtCor
            // 
            this.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.Location = new System.Drawing.Point(13, 146);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(136, 20);
            this.txtCor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(10, 58);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 45;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(13, 75);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(685, 48);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtCodFabrica
            // 
            this.txtCodFabrica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFabrica.Location = new System.Drawing.Point(120, 35);
            this.txtCodFabrica.Name = "txtCodFabrica";
            this.txtCodFabrica.Size = new System.Drawing.Size(100, 20);
            this.txtCodFabrica.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(117, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Código da Fábrica";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(11, 249);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 16);
            this.lblObservacao.TabIndex = 37;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(14, 266);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(685, 86);
            this.txtObservacao.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(256, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(259, 33);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(13, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // proPesquisar
            // 
            this.proPesquisar.Controls.Add(this.dataGridView1);
            this.proPesquisar.Controls.Add(this.textBox2);
            this.proPesquisar.Controls.Add(this.lblFiltro);
            this.proPesquisar.Controls.Add(this.cboOpcao);
            this.proPesquisar.Controls.Add(this.lblOpcao);
            this.proPesquisar.Location = new System.Drawing.Point(4, 22);
            this.proPesquisar.Name = "proPesquisar";
            this.proPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.proPesquisar.Size = new System.Drawing.Size(717, 363);
            this.proPesquisar.TabIndex = 1;
            this.proPesquisar.Text = "Pesquisar";
            this.proPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 296);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(505, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(203, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "CÓDIGO FABRICA",
            "NOME",
            "COR",
            "GRUPO DE PRODUTOS",
            "MATERIAL"});
            this.cboOpcao.Location = new System.Drawing.Point(10, 32);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(156, 21);
            this.cboOpcao.TabIndex = 1;
            this.cboOpcao.Text = "NOME";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(7, 13);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(128, 16);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Opção de Pesquisa";
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 417);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::CADASTRO DE PRODUTO:::.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.proDados.ResumeLayout(false);
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            this.proPesquisar.ResumeLayout(false);
            this.proPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabPage proDados;
        private System.Windows.Forms.TabPage proPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.TextBox txtCodFabrica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQntEstoque;
        private System.Windows.Forms.Label label7;
    }
}