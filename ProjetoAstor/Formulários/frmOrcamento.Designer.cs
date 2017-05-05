namespace ProjetoAstor.Formulários
{
    partial class frmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orcDados = new System.Windows.Forms.TabPage();
            this.grpOrcamento = new System.Windows.Forms.GroupBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.orcPesquisar = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataFaturamento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboParcelas = new System.Windows.Forms.ComboBox();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPrazoEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalItens = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.orcDados.SuspendLayout();
            this.grpOrcamento.SuspendLayout();
            this.orcPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.toolStrip1.TabIndex = 6;
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
            this.tabControl1.Controls.Add(this.orcDados);
            this.tabControl1.Controls.Add(this.orcPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 364);
            this.tabControl1.TabIndex = 7;
            // 
            // orcDados
            // 
            this.orcDados.Controls.Add(this.grpOrcamento);
            this.orcDados.Location = new System.Drawing.Point(4, 22);
            this.orcDados.Name = "orcDados";
            this.orcDados.Padding = new System.Windows.Forms.Padding(3);
            this.orcDados.Size = new System.Drawing.Size(717, 338);
            this.orcDados.TabIndex = 0;
            this.orcDados.Text = "Dados do Orçamento";
            this.orcDados.UseVisualStyleBackColor = true;
            // 
            // grpOrcamento
            // 
            this.grpOrcamento.Controls.Add(this.txtTotalDesconto);
            this.grpOrcamento.Controls.Add(this.label12);
            this.grpOrcamento.Controls.Add(this.txtTotalItens);
            this.grpOrcamento.Controls.Add(this.label11);
            this.grpOrcamento.Controls.Add(this.txtPesoTotal);
            this.grpOrcamento.Controls.Add(this.label10);
            this.grpOrcamento.Controls.Add(this.txtFrete);
            this.grpOrcamento.Controls.Add(this.label9);
            this.grpOrcamento.Controls.Add(this.txtDesconto);
            this.grpOrcamento.Controls.Add(this.label8);
            this.grpOrcamento.Controls.Add(this.cboFormaPagamento);
            this.grpOrcamento.Controls.Add(this.txtComprador);
            this.grpOrcamento.Controls.Add(this.label7);
            this.grpOrcamento.Controls.Add(this.label6);
            this.grpOrcamento.Controls.Add(this.dtpPrazoEntrega);
            this.grpOrcamento.Controls.Add(this.cboProdutos);
            this.grpOrcamento.Controls.Add(this.label5);
            this.grpOrcamento.Controls.Add(this.cboParcelas);
            this.grpOrcamento.Controls.Add(this.label4);
            this.grpOrcamento.Controls.Add(this.label3);
            this.grpOrcamento.Controls.Add(this.label2);
            this.grpOrcamento.Controls.Add(this.dtpDataFaturamento);
            this.grpOrcamento.Controls.Add(this.txtNomeVendedor);
            this.grpOrcamento.Controls.Add(this.label1);
            this.grpOrcamento.Controls.Add(this.txtCliente);
            this.grpOrcamento.Controls.Add(this.lblCliente);
            this.grpOrcamento.Controls.Add(this.lblData);
            this.grpOrcamento.Controls.Add(this.dtpData);
            this.grpOrcamento.Controls.Add(this.lblObservacao);
            this.grpOrcamento.Controls.Add(this.txtObservacao);
            this.grpOrcamento.Controls.Add(this.txtCodigo);
            this.grpOrcamento.Controls.Add(this.lblCodigo);
            this.grpOrcamento.Location = new System.Drawing.Point(7, 0);
            this.grpOrcamento.Name = "grpOrcamento";
            this.grpOrcamento.Size = new System.Drawing.Size(704, 332);
            this.grpOrcamento.TabIndex = 0;
            this.grpOrcamento.TabStop = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(10, 223);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 16);
            this.lblObservacao.TabIndex = 37;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(13, 240);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(685, 86);
            this.txtObservacao.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(13, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(10, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // orcPesquisar
            // 
            this.orcPesquisar.Controls.Add(this.dgvClientes);
            this.orcPesquisar.Controls.Add(this.txtFiltro);
            this.orcPesquisar.Controls.Add(this.lblFiltro);
            this.orcPesquisar.Controls.Add(this.cboOpcao);
            this.orcPesquisar.Controls.Add(this.lblOpcao);
            this.orcPesquisar.Location = new System.Drawing.Point(4, 22);
            this.orcPesquisar.Name = "orcPesquisar";
            this.orcPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.orcPesquisar.Size = new System.Drawing.Size(717, 338);
            this.orcPesquisar.TabIndex = 1;
            this.orcPesquisar.Text = "Pesquisar";
            this.orcPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 59);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(705, 273);
            this.dgvClientes.TabIndex = 4;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(206, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(505, 20);
            this.txtFiltro.TabIndex = 3;
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
            "CÓDIGO",
            "NOME",
            "SOBRENOME",
            "CNPJ",
            "INS. ESTADUAL",
            "CPF",
            "RG",
            "CIDADE",
            "E-MAIL",
            "PESSOA FÍSICA",
            "PESSOA JURÍDICA"});
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
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(152, 34);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(99, 20);
            this.dtpData.TabIndex = 38;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(149, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 16);
            this.lblData.TabIndex = 39;
            this.lblData.Text = "Data";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(277, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 41;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(280, 34);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(418, 21);
            this.txtCliente.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Vendedor";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Enabled = false;
            this.txtNomeVendedor.Location = new System.Drawing.Point(13, 89);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(176, 20);
            this.txtNomeVendedor.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Data Faturamento";
            // 
            // dtpDataFaturamento
            // 
            this.dtpDataFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFaturamento.Location = new System.Drawing.Point(214, 89);
            this.dtpDataFaturamento.Name = "dtpDataFaturamento";
            this.dtpDataFaturamento.Size = new System.Drawing.Size(112, 20);
            this.dtpDataFaturamento.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Forma de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Parcelas";
            // 
            // cboParcelas
            // 
            this.cboParcelas.FormattingEnabled = true;
            this.cboParcelas.Items.AddRange(new object[] {
            "1 PARCELA",
            "2 PARCELAS",
            "3 PARCELAS",
            "4 PARCELAS",
            "5 PARCELAS",
            "6 PARCELAS",
            "7 PARCELAS",
            "8 PARCELAS",
            "9 PARCELAS",
            "10 PARCELAS"});
            this.cboParcelas.Location = new System.Drawing.Point(562, 88);
            this.cboParcelas.Name = "cboParcelas";
            this.cboParcelas.Size = new System.Drawing.Size(136, 21);
            this.cboParcelas.TabIndex = 50;
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Items.AddRange(new object[] {
            "1 PARCELA",
            "2 PARCELAS",
            "3 PARCELAS",
            "4 PARCELAS",
            "5 PARCELAS",
            "6 PARCELAS",
            "7 PARCELAS",
            "8 PARCELAS",
            "9 PARCELAS",
            "10 PARCELAS"});
            this.cboProdutos.Location = new System.Drawing.Point(13, 142);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(313, 21);
            this.cboProdutos.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Prazo de Entrega";
            // 
            // dtpPrazoEntrega
            // 
            this.dtpPrazoEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazoEntrega.Location = new System.Drawing.Point(349, 143);
            this.dtpPrazoEntrega.Name = "dtpPrazoEntrega";
            this.dtpPrazoEntrega.Size = new System.Drawing.Size(112, 20);
            this.dtpPrazoEntrega.TabIndex = 53;
            // 
            // txtComprador
            // 
            this.txtComprador.Enabled = false;
            this.txtComprador.Location = new System.Drawing.Point(480, 143);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(218, 20);
            this.txtComprador.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nome Comprador";
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Items.AddRange(new object[] {
            "BOLETO",
            "CARTÃO",
            "DINHEIRO",
            "CHÉQUE",
            "DEPÓSITO",
            "TRANSFERÊNCIA"});
            this.cboFormaPagamento.Location = new System.Drawing.Point(349, 88);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(189, 21);
            this.cboFormaPagamento.TabIndex = 57;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(13, 196);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(86, 20);
            this.txtDesconto.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Desconto (%)";
            // 
            // txtFrete
            // 
            this.txtFrete.Enabled = false;
            this.txtFrete.Location = new System.Drawing.Point(139, 196);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(86, 20);
            this.txtFrete.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Frete";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Enabled = false;
            this.txtPesoTotal.Location = new System.Drawing.Point(261, 196);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(104, 20);
            this.txtPesoTotal.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Peso Total (Kg. )";
            // 
            // txtTotalItens
            // 
            this.txtTotalItens.Enabled = false;
            this.txtTotalItens.Location = new System.Drawing.Point(390, 196);
            this.txtTotalItens.Name = "txtTotalItens";
            this.txtTotalItens.Size = new System.Drawing.Size(148, 20);
            this.txtTotalItens.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Total de Itens";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Location = new System.Drawing.Point(562, 196);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(136, 20);
            this.txtTotalDesconto.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(559, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Total Desconto";
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOrcamento";
            this.Text = ".:::CADASTRO DE ORÇAMENTO:::.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.orcDados.ResumeLayout(false);
            this.grpOrcamento.ResumeLayout(false);
            this.grpOrcamento.PerformLayout();
            this.orcPesquisar.ResumeLayout(false);
            this.orcPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.TabPage orcDados;
        private System.Windows.Forms.GroupBox grpOrcamento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage orcPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFaturamento;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboParcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPrazoEntrega;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalItens;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.Label label10;
    }
}