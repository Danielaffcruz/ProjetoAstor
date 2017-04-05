namespace ProjetoAstor
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.funDados = new System.Windows.Forms.TabPage();
            this.grpFuncionarios = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemuneracao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.SuspendLayout();
            this.funDados.SuspendLayout();
            this.grpFuncionarios.SuspendLayout();
            this.funPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.funDados);
            this.tabControl1.Controls.Add(this.funPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 364);
            this.tabControl1.TabIndex = 4;
            // 
            // funDados
            // 
            this.funDados.Controls.Add(this.grpFuncionarios);
            this.funDados.Location = new System.Drawing.Point(4, 22);
            this.funDados.Name = "funDados";
            this.funDados.Padding = new System.Windows.Forms.Padding(3);
            this.funDados.Size = new System.Drawing.Size(717, 338);
            this.funDados.TabIndex = 0;
            this.funDados.Text = "Dados do Funcionário";
            this.funDados.UseVisualStyleBackColor = true;
            // 
            // grpFuncionarios
            // 
            this.grpFuncionarios.Controls.Add(this.btnPesquisar);
            this.grpFuncionarios.Controls.Add(this.label2);
            this.grpFuncionarios.Controls.Add(this.txtRemuneracao);
            this.grpFuncionarios.Controls.Add(this.lblObservacao);
            this.grpFuncionarios.Controls.Add(this.txtObservacao);
            this.grpFuncionarios.Controls.Add(this.lblEmail);
            this.grpFuncionarios.Controls.Add(this.txtEmail);
            this.grpFuncionarios.Controls.Add(this.mskCelular);
            this.grpFuncionarios.Controls.Add(this.lblCelular);
            this.grpFuncionarios.Controls.Add(this.mskTelefone);
            this.grpFuncionarios.Controls.Add(this.lblTelefone);
            this.grpFuncionarios.Controls.Add(this.cmbEstado);
            this.grpFuncionarios.Controls.Add(this.lblEstado);
            this.grpFuncionarios.Controls.Add(this.lblCidade);
            this.grpFuncionarios.Controls.Add(this.txtCidade);
            this.grpFuncionarios.Controls.Add(this.lblBairro);
            this.grpFuncionarios.Controls.Add(this.txtBairro);
            this.grpFuncionarios.Controls.Add(this.label3);
            this.grpFuncionarios.Controls.Add(this.txtNumero);
            this.grpFuncionarios.Controls.Add(this.lblEndereco);
            this.grpFuncionarios.Controls.Add(this.txtEndereco);
            this.grpFuncionarios.Controls.Add(this.mskCEP);
            this.grpFuncionarios.Controls.Add(this.lblCEP);
            this.grpFuncionarios.Controls.Add(this.mskRG);
            this.grpFuncionarios.Controls.Add(this.lblRG);
            this.grpFuncionarios.Controls.Add(this.mskCPF);
            this.grpFuncionarios.Controls.Add(this.lblCPF);
            this.grpFuncionarios.Controls.Add(this.lblSobrenome);
            this.grpFuncionarios.Controls.Add(this.txtSobrenome);
            this.grpFuncionarios.Controls.Add(this.lblNome);
            this.grpFuncionarios.Controls.Add(this.txtNome);
            this.grpFuncionarios.Controls.Add(this.txtCodigo);
            this.grpFuncionarios.Controls.Add(this.label1);
            this.grpFuncionarios.Location = new System.Drawing.Point(7, 0);
            this.grpFuncionarios.Name = "grpFuncionarios";
            this.grpFuncionarios.Size = new System.Drawing.Size(704, 332);
            this.grpFuncionarios.TabIndex = 0;
            this.grpFuncionarios.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(82, 138);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(24, 24);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Remuneração (R$)";
            // 
            // txtRemuneracao
            // 
            this.txtRemuneracao.Location = new System.Drawing.Point(210, 82);
            this.txtRemuneracao.MaxLength = 100;
            this.txtRemuneracao.Name = "txtRemuneracao";
            this.txtRemuneracao.Size = new System.Drawing.Size(182, 20);
            this.txtRemuneracao.TabIndex = 38;
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
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(685, 86);
            this.txtObservacao.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(410, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(413, 84);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(512, 195);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(83, 20);
            this.mskCelular.TabIndex = 14;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(509, 176);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 16);
            this.lblCelular.TabIndex = 30;
            this.lblCelular.Text = "Celular";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(413, 192);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(78, 20);
            this.mskTelefone.TabIndex = 13;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(410, 176);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 16);
            this.lblTelefone.TabIndex = 28;
            this.lblTelefone.Text = "Telefone";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(288, 190);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(48, 21);
            this.cmbEstado.TabIndex = 12;
            this.cmbEstado.Text = "SP";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(285, 171);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(10, 172);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(14, 191);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(247, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(509, 122);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 16);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(512, 141);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(438, 141);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(111, 122);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(114, 141);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(306, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(13, 141);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(63, 20);
            this.mskCEP.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 122);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 16);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(117, 84);
            this.mskRG.Mask = "00.000.000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(72, 20);
            this.mskRG.TabIndex = 6;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(114, 65);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(28, 16);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(13, 84);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(85, 20);
            this.mskCPF.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(10, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 16);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(492, 16);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(79, 16);
            this.lblSobrenome.TabIndex = 5;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(495, 33);
            this.txtSobrenome.MaxLength = 100;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(203, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(140, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(143, 33);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(13, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // funPesquisar
            // 
            this.funPesquisar.Controls.Add(this.dataGridView1);
            this.funPesquisar.Controls.Add(this.txtFiltro);
            this.funPesquisar.Controls.Add(this.lblFiltro);
            this.funPesquisar.Controls.Add(this.cboOpcao);
            this.funPesquisar.Controls.Add(this.lblOpcao);
            this.funPesquisar.Location = new System.Drawing.Point(4, 22);
            this.funPesquisar.Name = "funPesquisar";
            this.funPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.funPesquisar.Size = new System.Drawing.Size(717, 338);
            this.funPesquisar.TabIndex = 1;
            this.funPesquisar.Text = "Pesquisar";
            this.funPesquisar.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(705, 273);
            this.dataGridView1.TabIndex = 4;
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
            "CPF",
            "RG",
            "E-MAIL"});
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
            this.toolStrip1.TabIndex = 5;
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
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 413);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:::CADASTRO DE FUNCIONÁRIO:::.";
            this.tabControl1.ResumeLayout(false);
            this.funDados.ResumeLayout(false);
            this.grpFuncionarios.ResumeLayout(false);
            this.grpFuncionarios.PerformLayout();
            this.funPesquisar.ResumeLayout(false);
            this.funPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage funDados;
        private System.Windows.Forms.GroupBox grpFuncionarios;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage funPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemuneracao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}