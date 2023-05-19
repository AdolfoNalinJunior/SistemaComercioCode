namespace SistemaComercio.br.com.projetos.view
{
    partial class frmFuncionario
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
            this.tcFuncionario = new System.Windows.Forms.TabControl();
            this.tabCadastrarFuncionario = new System.Windows.Forms.TabPage();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabConsultarFuncionario = new System.Windows.Forms.TabPage();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.lblNomeCC = new System.Windows.Forms.Label();
            this.dgListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.tcFuncionario.SuspendLayout();
            this.tabCadastrarFuncionario.SuspendLayout();
            this.tabConsultarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFuncionario
            // 
            this.tcFuncionario.Controls.Add(this.tabCadastrarFuncionario);
            this.tcFuncionario.Controls.Add(this.tabConsultarFuncionario);
            this.tcFuncionario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tcFuncionario.Location = new System.Drawing.Point(12, 12);
            this.tcFuncionario.Name = "tcFuncionario";
            this.tcFuncionario.SelectedIndex = 0;
            this.tcFuncionario.Size = new System.Drawing.Size(776, 426);
            this.tcFuncionario.TabIndex = 1;
            this.tcFuncionario.UseWaitCursor = true;
            // 
            // tabCadastrarFuncionario
            // 
            this.tabCadastrarFuncionario.Controls.Add(this.cbNivelAcesso);
            this.tabCadastrarFuncionario.Controls.Add(this.lblNivelAcesso);
            this.tabCadastrarFuncionario.Controls.Add(this.txtSenha);
            this.tabCadastrarFuncionario.Controls.Add(this.lblSenha);
            this.tabCadastrarFuncionario.Controls.Add(this.cbCargo);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCargo);
            this.tabCadastrarFuncionario.Controls.Add(this.txtCidade);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCidade);
            this.tabCadastrarFuncionario.Controls.Add(this.btnSalvar);
            this.tabCadastrarFuncionario.Controls.Add(this.btnExcluir);
            this.tabCadastrarFuncionario.Controls.Add(this.btnEditar);
            this.tabCadastrarFuncionario.Controls.Add(this.btnNovo);
            this.tabCadastrarFuncionario.Controls.Add(this.txtNumero);
            this.tabCadastrarFuncionario.Controls.Add(this.lblNumero);
            this.tabCadastrarFuncionario.Controls.Add(this.txtComplemento);
            this.tabCadastrarFuncionario.Controls.Add(this.lblComplemento);
            this.tabCadastrarFuncionario.Controls.Add(this.lblBairro);
            this.tabCadastrarFuncionario.Controls.Add(this.txtBairro);
            this.tabCadastrarFuncionario.Controls.Add(this.cbEstado);
            this.tabCadastrarFuncionario.Controls.Add(this.lblEstado);
            this.tabCadastrarFuncionario.Controls.Add(this.mtbCEP);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCEP);
            this.tabCadastrarFuncionario.Controls.Add(this.lblTelefone);
            this.tabCadastrarFuncionario.Controls.Add(this.mtbTelefone);
            this.tabCadastrarFuncionario.Controls.Add(this.lblRG);
            this.tabCadastrarFuncionario.Controls.Add(this.mtbRG);
            this.tabCadastrarFuncionario.Controls.Add(this.txtCodigo);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCodigo);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCPF);
            this.tabCadastrarFuncionario.Controls.Add(this.mtbCPF);
            this.tabCadastrarFuncionario.Controls.Add(this.lblCelular);
            this.tabCadastrarFuncionario.Controls.Add(this.mtbCelular);
            this.tabCadastrarFuncionario.Controls.Add(this.txtEndereco);
            this.tabCadastrarFuncionario.Controls.Add(this.lblEndereco);
            this.tabCadastrarFuncionario.Controls.Add(this.txtEmail);
            this.tabCadastrarFuncionario.Controls.Add(this.lblEmail);
            this.tabCadastrarFuncionario.Controls.Add(this.txtNome);
            this.tabCadastrarFuncionario.Controls.Add(this.lblNome);
            this.tabCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabCadastrarFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCadastrarFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarFuncionario.Name = "tabCadastrarFuncionario";
            this.tabCadastrarFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarFuncionario.Size = new System.Drawing.Size(768, 400);
            this.tabCadastrarFuncionario.TabIndex = 0;
            this.tabCadastrarFuncionario.Text = " Cadastrar Funcionário";
            this.tabCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.tabCadastrarFuncionario.UseWaitCursor = true;
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "Vendedor",
            "Gerente",
            "Dono",
            "Gerente de estoque",
            "Estoque",
            "Administrador",
            "Assistente administrativo",
            "Sub gerente"});
            this.cbNivelAcesso.Location = new System.Drawing.Point(308, 136);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(98, 21);
            this.cbNivelAcesso.TabIndex = 39;
            this.cbNivelAcesso.UseWaitCursor = true;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Location = new System.Drawing.Point(215, 139);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(87, 13);
            this.lblNivelAcesso.TabIndex = 38;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            this.lblNivelAcesso.UseWaitCursor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(71, 133);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(105, 20);
            this.txtSenha.TabIndex = 37;
            this.txtSenha.UseWaitCursor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(30, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 36;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.UseWaitCursor = true;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Vendedor",
            "Gerente",
            "Dono",
            "Gerente de estoque",
            "Estoque",
            "Administrador",
            "Assistente administrativo",
            "Sub gerente"});
            this.cbCargo.Location = new System.Drawing.Point(611, 133);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(69, 21);
            this.cbCargo.TabIndex = 35;
            this.cbCargo.UseWaitCursor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(570, 136);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 34;
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.UseWaitCursor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(185, 216);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(394, 20);
            this.txtCidade.TabIndex = 33;
            this.txtCidade.UseWaitCursor = true;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(139, 218);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 32;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.UseWaitCursor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(468, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 39);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.UseWaitCursor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.Location = new System.Drawing.Point(375, 316);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 39);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.UseWaitCursor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Location = new System.Drawing.Point(288, 316);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 39);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.UseWaitCursor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Location = new System.Drawing.Point(201, 316);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 39);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.UseWaitCursor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(657, 216);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 27;
            this.txtNumero.UseWaitCursor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(604, 219);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 26;
            this.lblNumero.Text = "Número:";
            this.lblNumero.UseWaitCursor = true;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(117, 270);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(534, 25);
            this.txtComplemento.TabIndex = 25;
            this.txtComplemento.UseWaitCursor = true;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(37, 273);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 24;
            this.lblComplemento.Text = "Complemento:";
            this.lblComplemento.UseWaitCursor = true;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(445, 172);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro: ";
            this.lblBairro.UseWaitCursor = true;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(485, 169);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(210, 20);
            this.txtBairro.TabIndex = 22;
            this.txtBairro.UseWaitCursor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
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
            "PR",
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
            "TO\t"});
            this.cbEstado.Location = new System.Drawing.Point(83, 216);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(44, 21);
            this.cbEstado.TabIndex = 21;
            this.cbEstado.UseWaitCursor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(34, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.UseWaitCursor = true;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(66, 169);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(61, 20);
            this.mtbCEP.TabIndex = 18;
            this.mtbCEP.UseWaitCursor = true;
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(30, 172);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(30, 13);
            this.lblCEP.TabIndex = 17;
            this.lblCEP.Text = "CPF:";
            this.lblCEP.UseWaitCursor = true;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(375, 96);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 15;
            this.lblTelefone.Text = "Telefone: ";
            this.lblTelefone.UseWaitCursor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(427, 94);
            this.mtbTelefone.Mask = "(99) 9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(85, 20);
            this.mtbTelefone.TabIndex = 14;
            this.mtbTelefone.UseWaitCursor = true;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(570, 53);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 13;
            this.lblRG.Text = "RG:";
            this.lblRG.UseWaitCursor = true;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(599, 50);
            this.mtbRG.Mask = "999,999,999-99";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(85, 20);
            this.mtbRG.TabIndex = 12;
            this.mtbRG.UseWaitCursor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.UseWaitCursor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseWaitCursor = true;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(431, 53);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.UseWaitCursor = true;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(467, 50);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(85, 20);
            this.mtbCPF.TabIndex = 8;
            this.mtbCPF.UseWaitCursor = true;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(552, 98);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 7;
            this.lblCelular.Text = "Celular:";
            this.lblCelular.UseWaitCursor = true;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(594, 95);
            this.mtbCelular.Mask = "(99) 9999-99999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(85, 20);
            this.mtbCelular.TabIndex = 6;
            this.mtbCelular.UseWaitCursor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(203, 169);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(227, 20);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.UseWaitCursor = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(149, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço: ";
            this.lblEndereco.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseWaitCursor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: ";
            this.lblEmail.UseWaitCursor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(179, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseWaitCursor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(138, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.UseWaitCursor = true;
            // 
            // tabConsultarFuncionario
            // 
            this.tabConsultarFuncionario.Controls.Add(this.txtNomeConsulta);
            this.tabConsultarFuncionario.Controls.Add(this.lblNomeCC);
            this.tabConsultarFuncionario.Controls.Add(this.dgListaFuncionarios);
            this.tabConsultarFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarFuncionario.Name = "tabConsultarFuncionario";
            this.tabConsultarFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarFuncionario.Size = new System.Drawing.Size(768, 400);
            this.tabConsultarFuncionario.TabIndex = 1;
            this.tabConsultarFuncionario.Text = "Consultar Funcionário";
            this.tabConsultarFuncionario.UseVisualStyleBackColor = true;
            this.tabConsultarFuncionario.UseWaitCursor = true;
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(62, 17);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(283, 20);
            this.txtNomeConsulta.TabIndex = 2;
            this.txtNomeConsulta.UseWaitCursor = true;
            this.txtNomeConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeConsulta_KeyPress);
            // 
            // lblNomeCC
            // 
            this.lblNomeCC.AutoSize = true;
            this.lblNomeCC.Location = new System.Drawing.Point(18, 20);
            this.lblNomeCC.Name = "lblNomeCC";
            this.lblNomeCC.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCC.TabIndex = 1;
            this.lblNomeCC.Text = "Nome:";
            this.lblNomeCC.UseWaitCursor = true;
            // 
            // dgListaFuncionarios
            // 
            this.dgListaFuncionarios.AllowUserToAddRows = false;
            this.dgListaFuncionarios.AllowUserToDeleteRows = false;
            this.dgListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFuncionarios.Location = new System.Drawing.Point(16, 106);
            this.dgListaFuncionarios.Name = "dgListaFuncionarios";
            this.dgListaFuncionarios.ReadOnly = true;
            this.dgListaFuncionarios.Size = new System.Drawing.Size(736, 273);
            this.dgListaFuncionarios.TabIndex = 0;
            this.dgListaFuncionarios.UseWaitCursor = true;
            this.dgListaFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaFuncionarios_CellClick);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcFuncionario);
            this.Name = "frmFuncionario";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.tcFuncionario.ResumeLayout(false);
            this.tabCadastrarFuncionario.ResumeLayout(false);
            this.tabCadastrarFuncionario.PerformLayout();
            this.tabConsultarFuncionario.ResumeLayout(false);
            this.tabConsultarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label lblNomeCC;
        private System.Windows.Forms.DataGridView dgListaFuncionarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.Label lblNivelAcesso;
        public System.Windows.Forms.TabPage tabCadastrarFuncionario;
        public System.Windows.Forms.TabPage tabConsultarFuncionario;
        public System.Windows.Forms.TabControl tcFuncionario;
    }
}