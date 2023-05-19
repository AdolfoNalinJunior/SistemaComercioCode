namespace SistemaComercio.br.com.projetos.view
{
    partial class frmMenu
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricosDeVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.venToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClientesToolStripMenuItem,
            this.cadastrarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar Clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultarFuncionáriosToolStripMenuItem,
            this.cadastrarFuncionáriosToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.Funcionario;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // ConsultarFuncionáriosToolStripMenuItem
            // 
            this.ConsultarFuncionáriosToolStripMenuItem.Name = "ConsultarFuncionáriosToolStripMenuItem";
            this.ConsultarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ConsultarFuncionáriosToolStripMenuItem.Text = "Consultar Funcionários";
            this.ConsultarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarFuncionáriosToolStripMenuItem_Click);
            // 
            // cadastrarFuncionáriosToolStripMenuItem1
            // 
            this.cadastrarFuncionáriosToolStripMenuItem1.Name = "cadastrarFuncionáriosToolStripMenuItem1";
            this.cadastrarFuncionáriosToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.cadastrarFuncionáriosToolStripMenuItem1.Text = "Cadastrar Funcionários";
            this.cadastrarFuncionáriosToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarFuncionáriosToolStripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFornecedoresToolStripMenuItem,
            this.cadastrarFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.Forncedores;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // consultarFornecedoresToolStripMenuItem
            // 
            this.consultarFornecedoresToolStripMenuItem.Name = "consultarFornecedoresToolStripMenuItem";
            this.consultarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.consultarFornecedoresToolStripMenuItem.Text = "Consultar Fornecedores";
            this.consultarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.consultarFornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarFornecedoresToolStripMenuItem
            // 
            this.cadastrarFornecedoresToolStripMenuItem.Name = "cadastrarFornecedoresToolStripMenuItem";
            this.cadastrarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cadastrarFornecedoresToolStripMenuItem.Text = "Cadastrar Fornecedores";
            this.cadastrarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProdutosToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.Produtos;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Consultar Produtos";
            this.consultarProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutosToolStripMenuItem_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // venToolStripMenuItem
            // 
            this.venToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaDeVendasToolStripMenuItem,
            this.históricosDeVEToolStripMenuItem});
            this.venToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.Venda;
            this.venToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.venToolStripMenuItem.Name = "venToolStripMenuItem";
            this.venToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.venToolStripMenuItem.Text = "Vendas";
            // 
            // telaDeVendasToolStripMenuItem
            // 
            this.telaDeVendasToolStripMenuItem.Name = "telaDeVendasToolStripMenuItem";
            this.telaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.telaDeVendasToolStripMenuItem.Text = "Tela de vendas";
            this.telaDeVendasToolStripMenuItem.Click += new System.EventHandler(this.telaDeVendasToolStripMenuItem_Click);
            // 
            // históricosDeVEToolStripMenuItem
            // 
            this.históricosDeVEToolStripMenuItem.Name = "históricosDeVEToolStripMenuItem";
            this.históricosDeVEToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.históricosDeVEToolStripMenuItem.Text = "Históricos de Vendas";
            this.históricosDeVEToolStripMenuItem.Click += new System.EventHandler(this.históricosDeVEToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDoSistemaToolStripMenuItem,
            this.trocarDeUsuárioToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Image = global::SistemaComercio.Properties.Resources.Configuração;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssData,
            this.txtData,
            this.tssHora,
            this.txtHora,
            this.tssUsuario,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssData
            // 
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(65, 17);
            this.tssData.Text = "Data Atual:";
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(0, 17);
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(67, 17);
            this.tssHora.Text = "Hora Atual:";
            // 
            // txtHora
            // 
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(0, 17);
            // 
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(81, 17);
            this.tssUsuario.Text = "Usuário Local:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmMenu";
            this.Text = "Menu Do Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricosDeVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        public System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        public System.Windows.Forms.ToolStripStatusLabel txtData;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
    }
}