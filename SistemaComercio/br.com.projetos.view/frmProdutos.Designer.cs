namespace SistemaComercio.br.com.projetos.view
{
    partial class frmProdutos
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
            this.tabConsultarProdutos = new System.Windows.Forms.TabPage();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.lblNomeCC = new System.Windows.Forms.Label();
            this.dgListaProdutos = new System.Windows.Forms.DataGridView();
            this.tcProduto = new System.Windows.Forms.TabControl();
            this.tabCadastrarProdutos = new System.Windows.Forms.TabPage();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.tabConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProdutos)).BeginInit();
            this.tcProduto.SuspendLayout();
            this.tabCadastrarProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConsultarProdutos
            // 
            this.tabConsultarProdutos.Controls.Add(this.txtNomeConsulta);
            this.tabConsultarProdutos.Controls.Add(this.lblNomeCC);
            this.tabConsultarProdutos.Controls.Add(this.dgListaProdutos);
            this.tabConsultarProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarProdutos.Name = "tabConsultarProdutos";
            this.tabConsultarProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarProdutos.Size = new System.Drawing.Size(768, 400);
            this.tabConsultarProdutos.TabIndex = 1;
            this.tabConsultarProdutos.Text = "Consultar Produtos";
            this.tabConsultarProdutos.UseVisualStyleBackColor = true;
            this.tabConsultarProdutos.UseWaitCursor = true;
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
            // dgListaProdutos
            // 
            this.dgListaProdutos.AllowUserToAddRows = false;
            this.dgListaProdutos.AllowUserToDeleteRows = false;
            this.dgListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaProdutos.Location = new System.Drawing.Point(16, 106);
            this.dgListaProdutos.Name = "dgListaProdutos";
            this.dgListaProdutos.ReadOnly = true;
            this.dgListaProdutos.Size = new System.Drawing.Size(736, 273);
            this.dgListaProdutos.TabIndex = 0;
            this.dgListaProdutos.UseWaitCursor = true;
            this.dgListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProdutos_CellContentClick);
            // 
            // tcProduto
            // 
            this.tcProduto.Controls.Add(this.tabCadastrarProdutos);
            this.tcProduto.Controls.Add(this.tabConsultarProdutos);
            this.tcProduto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tcProduto.Location = new System.Drawing.Point(12, 12);
            this.tcProduto.Name = "tcProduto";
            this.tcProduto.SelectedIndex = 0;
            this.tcProduto.Size = new System.Drawing.Size(776, 426);
            this.tcProduto.TabIndex = 2;
            this.tcProduto.UseWaitCursor = true;
            // 
            // tabCadastrarProdutos
            // 
            this.tabCadastrarProdutos.Controls.Add(this.txtValor);
            this.tabCadastrarProdutos.Controls.Add(this.lblEstoque);
            this.tabCadastrarProdutos.Controls.Add(this.btnSalvar);
            this.tabCadastrarProdutos.Controls.Add(this.btnExcluir);
            this.tabCadastrarProdutos.Controls.Add(this.btnEditar);
            this.tabCadastrarProdutos.Controls.Add(this.btnNovo);
            this.tabCadastrarProdutos.Controls.Add(this.txtDescricao);
            this.tabCadastrarProdutos.Controls.Add(this.lblDescricao);
            this.tabCadastrarProdutos.Controls.Add(this.cbFornecedor);
            this.tabCadastrarProdutos.Controls.Add(this.lblFornecedores);
            this.tabCadastrarProdutos.Controls.Add(this.txtCodigo);
            this.tabCadastrarProdutos.Controls.Add(this.lblCodigo);
            this.tabCadastrarProdutos.Controls.Add(this.txtEstoque);
            this.tabCadastrarProdutos.Controls.Add(this.lblPreco);
            this.tabCadastrarProdutos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabCadastrarProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCadastrarProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarProdutos.Name = "tabCadastrarProdutos";
            this.tabCadastrarProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarProdutos.Size = new System.Drawing.Size(768, 400);
            this.tabCadastrarProdutos.TabIndex = 0;
            this.tabCadastrarProdutos.Text = "  Cadastrar Produto";
            this.tabCadastrarProdutos.UseVisualStyleBackColor = true;
            this.tabCadastrarProdutos.UseWaitCursor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(116, 222);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(61, 20);
            this.txtValor.TabIndex = 33;
            this.txtValor.UseWaitCursor = true;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(67, 180);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 32;
            this.lblEstoque.Text = "Estoque:";
            this.lblEstoque.UseWaitCursor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(460, 316);
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 104);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(383, 50);
            this.txtDescricao.TabIndex = 25;
            this.txtDescricao.UseWaitCursor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(57, 107);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 24;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.UseWaitCursor = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
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
            this.cbFornecedor.Location = new System.Drawing.Point(116, 263);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(95, 21);
            this.cbFornecedor.TabIndex = 21;
            this.cbFornecedor.UseWaitCursor = true;
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Location = new System.Drawing.Point(38, 266);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(72, 13);
            this.lblFornecedores.TabIndex = 20;
            this.lblFornecedores.Text = "Fornecedores";
            this.lblFornecedores.UseWaitCursor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.UseWaitCursor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(73, 69);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseWaitCursor = true;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(116, 177);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(47, 20);
            this.txtEstoque.TabIndex = 3;
            this.txtEstoque.UseWaitCursor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(72, 225);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço:";
            this.lblPreco.UseWaitCursor = true;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcProduto);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.tabConsultarProdutos.ResumeLayout(false);
            this.tabConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProdutos)).EndInit();
            this.tcProduto.ResumeLayout(false);
            this.tabCadastrarProdutos.ResumeLayout(false);
            this.tabCadastrarProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label lblNomeCC;
        private System.Windows.Forms.DataGridView dgListaProdutos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.MaskedTextBox txtValor;
        public System.Windows.Forms.TabControl tcProduto;
        public System.Windows.Forms.TabPage tabConsultarProdutos;
        public System.Windows.Forms.TabPage tabCadastrarProdutos;
    }
}