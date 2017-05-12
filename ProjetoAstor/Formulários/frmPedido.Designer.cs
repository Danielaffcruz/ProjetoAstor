namespace ProjetoAstor.Formulários
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pedDados = new System.Windows.Forms.TabPage();
            this.grpOrcamento = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPeçasAdiantar = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.ckbBaixoRelevoSeco = new System.Windows.Forms.CheckBox();
            this.ckbSilk = new System.Windows.Forms.CheckBox();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ckbEtiquetaPapelao = new System.Windows.Forms.CheckBox();
            this.ckbAdiantamento = new System.Windows.Forms.CheckBox();
            this.ckbRevenda = new System.Windows.Forms.CheckBox();
            this.txtQuantidadeCaixas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalItens = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPrazoEntrega = new System.Windows.Forms.DateTimePicker();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pedPesquisar = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.tstGerarOS = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pedDados.SuspendLayout();
            this.grpOrcamento.SuspendLayout();
            this.pedPesquisar.SuspendLayout();
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
            this.tstGerarOS,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
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
            this.tabControl1.Controls.Add(this.pedDados);
            this.tabControl1.Controls.Add(this.pedPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 406);
            this.tabControl1.TabIndex = 8;
            // 
            // pedDados
            // 
            this.pedDados.Controls.Add(this.grpOrcamento);
            this.pedDados.Location = new System.Drawing.Point(4, 22);
            this.pedDados.Name = "pedDados";
            this.pedDados.Padding = new System.Windows.Forms.Padding(3);
            this.pedDados.Size = new System.Drawing.Size(717, 380);
            this.pedDados.TabIndex = 0;
            this.pedDados.Text = "Dados do Pedido";
            this.pedDados.UseVisualStyleBackColor = true;
            // 
            // grpOrcamento
            // 
            this.grpOrcamento.Controls.Add(this.label7);
            this.grpOrcamento.Controls.Add(this.dtpPeçasAdiantar);
            this.grpOrcamento.Controls.Add(this.textBox2);
            this.grpOrcamento.Controls.Add(this.label4);
            this.grpOrcamento.Controls.Add(this.textBox1);
            this.grpOrcamento.Controls.Add(this.label3);
            this.grpOrcamento.Controls.Add(this.checkBox4);
            this.grpOrcamento.Controls.Add(this.ckbBaixoRelevoSeco);
            this.grpOrcamento.Controls.Add(this.ckbSilk);
            this.grpOrcamento.Controls.Add(this.cboTransporte);
            this.grpOrcamento.Controls.Add(this.lblTransporte);
            this.grpOrcamento.Controls.Add(this.checkBox3);
            this.grpOrcamento.Controls.Add(this.checkBox1);
            this.grpOrcamento.Controls.Add(this.checkBox2);
            this.grpOrcamento.Controls.Add(this.ckbEtiquetaPapelao);
            this.grpOrcamento.Controls.Add(this.ckbAdiantamento);
            this.grpOrcamento.Controls.Add(this.ckbRevenda);
            this.grpOrcamento.Controls.Add(this.txtQuantidadeCaixas);
            this.grpOrcamento.Controls.Add(this.label1);
            this.grpOrcamento.Controls.Add(this.txtTotalItens);
            this.grpOrcamento.Controls.Add(this.label11);
            this.grpOrcamento.Controls.Add(this.label6);
            this.grpOrcamento.Controls.Add(this.dtpPrazoEntrega);
            this.grpOrcamento.Controls.Add(this.cboProdutos);
            this.grpOrcamento.Controls.Add(this.label5);
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
            this.grpOrcamento.Size = new System.Drawing.Size(704, 374);
            this.grpOrcamento.TabIndex = 0;
            this.grpOrcamento.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Até";
            // 
            // dtpPeçasAdiantar
            // 
            this.dtpPeçasAdiantar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeçasAdiantar.Location = new System.Drawing.Point(575, 223);
            this.dtpPeçasAdiantar.Name = "dtpPeçasAdiantar";
            this.dtpPeçasAdiantar.Size = new System.Drawing.Size(112, 20);
            this.dtpPeçasAdiantar.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(352, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Peças à Adiantar";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(352, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Ordem Cores Silk";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(217, 180);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 20);
            this.checkBox4.TabIndex = 79;
            this.checkBox4.Text = "Relevo/Silk";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // ckbBaixoRelevoSeco
            // 
            this.ckbBaixoRelevoSeco.AutoSize = true;
            this.ckbBaixoRelevoSeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBaixoRelevoSeco.Location = new System.Drawing.Point(90, 180);
            this.ckbBaixoRelevoSeco.Name = "ckbBaixoRelevoSeco";
            this.ckbBaixoRelevoSeco.Size = new System.Drawing.Size(106, 20);
            this.ckbBaixoRelevoSeco.TabIndex = 78;
            this.ckbBaixoRelevoSeco.Text = "Relevo Seco";
            this.ckbBaixoRelevoSeco.UseVisualStyleBackColor = true;
            // 
            // ckbSilk
            // 
            this.ckbSilk.AutoSize = true;
            this.ckbSilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSilk.Location = new System.Drawing.Point(13, 180);
            this.ckbSilk.Name = "ckbSilk";
            this.ckbSilk.Size = new System.Drawing.Size(49, 20);
            this.ckbSilk.TabIndex = 77;
            this.ckbSilk.Text = "Silk";
            this.ckbSilk.UseVisualStyleBackColor = true;
            // 
            // cboTransporte
            // 
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(352, 134);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(335, 21);
            this.cboTransporte.TabIndex = 76;
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.Location = new System.Drawing.Point(349, 116);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(102, 16);
            this.lblTransporte.TabIndex = 75;
            this.lblTransporte.Text = "Transportadora";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(217, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 20);
            this.checkBox3.TabIndex = 74;
            this.checkBox3.Text = "Retirado no local";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(90, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 20);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Transportadora";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(13, 135);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 20);
            this.checkBox2.TabIndex = 71;
            this.checkBox2.Text = "Correio";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ckbEtiquetaPapelao
            // 
            this.ckbEtiquetaPapelao.AutoSize = true;
            this.ckbEtiquetaPapelao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEtiquetaPapelao.Location = new System.Drawing.Point(13, 225);
            this.ckbEtiquetaPapelao.Name = "ckbEtiquetaPapelao";
            this.ckbEtiquetaPapelao.Size = new System.Drawing.Size(76, 20);
            this.ckbEtiquetaPapelao.TabIndex = 70;
            this.ckbEtiquetaPapelao.Text = "Etiqueta";
            this.ckbEtiquetaPapelao.UseVisualStyleBackColor = true;
            // 
            // ckbAdiantamento
            // 
            this.ckbAdiantamento.AutoSize = true;
            this.ckbAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAdiantamento.Location = new System.Drawing.Point(217, 225);
            this.ckbAdiantamento.Name = "ckbAdiantamento";
            this.ckbAdiantamento.Size = new System.Drawing.Size(110, 20);
            this.ckbAdiantamento.TabIndex = 69;
            this.ckbAdiantamento.Text = "Adiantamento";
            this.ckbAdiantamento.UseVisualStyleBackColor = true;
            // 
            // ckbRevenda
            // 
            this.ckbRevenda.AutoSize = true;
            this.ckbRevenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRevenda.Location = new System.Drawing.Point(90, 225);
            this.ckbRevenda.Name = "ckbRevenda";
            this.ckbRevenda.Size = new System.Drawing.Size(83, 20);
            this.ckbRevenda.TabIndex = 68;
            this.ckbRevenda.Text = "Revenda";
            this.ckbRevenda.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeCaixas
            // 
            this.txtQuantidadeCaixas.Enabled = false;
            this.txtQuantidadeCaixas.Location = new System.Drawing.Point(589, 87);
            this.txtQuantidadeCaixas.Name = "txtQuantidadeCaixas";
            this.txtQuantidadeCaixas.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidadeCaixas.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Quant. Caixas";
            // 
            // txtTotalItens
            // 
            this.txtTotalItens.Enabled = false;
            this.txtTotalItens.Location = new System.Drawing.Point(466, 87);
            this.txtTotalItens.Name = "txtTotalItens";
            this.txtTotalItens.Size = new System.Drawing.Size(98, 20);
            this.txtTotalItens.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Total de Itens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Prazo de Entrega";
            // 
            // dtpPrazoEntrega
            // 
            this.dtpPrazoEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazoEntrega.Location = new System.Drawing.Point(337, 87);
            this.dtpPrazoEntrega.Name = "dtpPrazoEntrega";
            this.dtpPrazoEntrega.Size = new System.Drawing.Size(112, 20);
            this.dtpPrazoEntrega.TabIndex = 53;
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
            this.cboProdutos.Location = new System.Drawing.Point(13, 86);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(313, 21);
            this.cboProdutos.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Produto";
            // 
            // txtCliente
            // 
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(245, 33);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(442, 21);
            this.txtCliente.TabIndex = 42;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(242, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 41;
            this.lblCliente.Text = "Cliente";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(127, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 16);
            this.lblData.TabIndex = 39;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(130, 34);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(99, 20);
            this.dtpData.TabIndex = 38;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(5, 264);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 16);
            this.lblObservacao.TabIndex = 37;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(8, 281);
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
            // pedPesquisar
            // 
            this.pedPesquisar.Controls.Add(this.dgvClientes);
            this.pedPesquisar.Controls.Add(this.txtFiltro);
            this.pedPesquisar.Controls.Add(this.lblFiltro);
            this.pedPesquisar.Controls.Add(this.cboOpcao);
            this.pedPesquisar.Controls.Add(this.lblOpcao);
            this.pedPesquisar.Location = new System.Drawing.Point(4, 22);
            this.pedPesquisar.Name = "pedPesquisar";
            this.pedPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.pedPesquisar.Size = new System.Drawing.Size(717, 380);
            this.pedPesquisar.TabIndex = 1;
            this.pedPesquisar.Text = "Pesquisar";
            this.pedPesquisar.UseVisualStyleBackColor = true;
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
            "CLIENTE",
            "PRODUTO",
            "TOTAL DE ITENS",
            "TRANSPORTADORA",
            "ADIANTAMENTO",
            "OBSERVAÇÃO"});
            this.cboOpcao.Location = new System.Drawing.Point(10, 32);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(156, 21);
            this.cboOpcao.TabIndex = 1;
            this.cboOpcao.Text = "CLIENTE";
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
            // tstGerarOS
            // 
            this.tstGerarOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstGerarOS.Image = ((System.Drawing.Image)(resources.GetObject("tstGerarOS.Image")));
            this.tstGerarOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstGerarOS.Name = "tstGerarOS";
            this.tstGerarOS.Size = new System.Drawing.Size(89, 22);
            this.tstGerarOS.Text = "Ordem Serviço";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPedido";
            this.Text = ".:::CADASTRO DE PEDIDO:::.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pedDados.ResumeLayout(false);
            this.grpOrcamento.ResumeLayout(false);
            this.grpOrcamento.PerformLayout();
            this.pedPesquisar.ResumeLayout(false);
            this.pedPesquisar.PerformLayout();
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
        private System.Windows.Forms.TabPage pedDados;
        private System.Windows.Forms.GroupBox grpOrcamento;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox ckbEtiquetaPapelao;
        private System.Windows.Forms.CheckBox ckbAdiantamento;
        private System.Windows.Forms.CheckBox ckbRevenda;
        private System.Windows.Forms.TextBox txtQuantidadeCaixas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalItens;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPrazoEntrega;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage pedPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox ckbBaixoRelevoSeco;
        private System.Windows.Forms.CheckBox ckbSilk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpPeçasAdiantar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tstGerarOS;
    }
}