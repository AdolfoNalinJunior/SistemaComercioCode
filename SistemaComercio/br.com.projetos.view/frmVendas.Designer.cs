namespace SistemaComercio.br.com.projetos.view
{
    partial class frmVendas
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.lblQuantiade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtIDProdutos = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.MaskedTextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblToTal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtEndereco);
            this.gbCliente.Controls.Add(this.lblEndereco);
            this.gbCliente.Controls.Add(this.lblNome);
            this.gbCliente.Controls.Add(this.txtNome);
            this.gbCliente.Controls.Add(this.lblID);
            this.gbCliente.Controls.Add(this.txtID);
            this.gbCliente.Controls.Add(this.mtbCPF);
            this.gbCliente.Controls.Add(this.lblCPF);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbCliente.Location = new System.Drawing.Point(18, 18);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(373, 138);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(84, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(264, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndereco.Location = new System.Drawing.Point(10, 93);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 15);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome.Location = new System.Drawing.Point(10, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblID.Location = new System.Drawing.Point(174, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 2;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(53, 25);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(93, 21);
            this.mtbCPF.TabIndex = 1;
            this.mtbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCPF_KeyPress);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCPF.Location = new System.Drawing.Point(10, 26);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 15);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.lblQuantiade);
            this.gbProduto.Controls.Add(this.txtQuantidade);
            this.gbProduto.Controls.Add(this.txtIDProdutos);
            this.gbProduto.Controls.Add(this.lblIdProduto);
            this.gbProduto.Controls.Add(this.txtPreco);
            this.gbProduto.Controls.Add(this.btnRemover);
            this.gbProduto.Controls.Add(this.btnAdd);
            this.gbProduto.Controls.Add(this.txtDescricao);
            this.gbProduto.Controls.Add(this.txtEstoque);
            this.gbProduto.Controls.Add(this.lblEstoque);
            this.gbProduto.Controls.Add(this.lblDescricao);
            this.gbProduto.Controls.Add(this.lblPreco);
            this.gbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbProduto.Location = new System.Drawing.Point(18, 162);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(373, 194);
            this.gbProduto.TabIndex = 1;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // lblQuantiade
            // 
            this.lblQuantiade.AutoSize = true;
            this.lblQuantiade.Location = new System.Drawing.Point(170, 56);
            this.lblQuantiade.Name = "lblQuantiade";
            this.lblQuantiade.Size = new System.Drawing.Size(76, 13);
            this.lblQuantiade.TabIndex = 21;
            this.lblQuantiade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(246, 53);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(54, 20);
            this.txtQuantidade.TabIndex = 20;
            // 
            // txtIDProdutos
            // 
            this.txtIDProdutos.Location = new System.Drawing.Point(76, 24);
            this.txtIDProdutos.Name = "txtIDProdutos";
            this.txtIDProdutos.Size = new System.Drawing.Size(53, 20);
            this.txtIDProdutos.TabIndex = 19;
            this.txtIDProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txIdProduto_KeyPress);
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIdProduto.Location = new System.Drawing.Point(45, 26);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(25, 15);
            this.lblIdProduto.TabIndex = 18;
            this.lblIdProduto.Text = "ID:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(76, 53);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(70, 20);
            this.txtPreco.TabIndex = 17;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRemover.Location = new System.Drawing.Point(76, 136);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(93, 35);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(207, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 82);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(283, 25);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(212, 24);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(54, 20);
            this.txtEstoque.TabIndex = 15;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstoque.Location = new System.Drawing.Point(143, 24);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(63, 15);
            this.lblEstoque.TabIndex = 14;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescricao.Location = new System.Drawing.Point(1, 83);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 15);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPreco.Location = new System.Drawing.Point(22, 54);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(48, 15);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSubtotal.Location = new System.Drawing.Point(396, 298);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(99, 24);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "SubTotal:";
            // 
            // lblToTal
            // 
            this.lblToTal.AutoSize = true;
            this.lblToTal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblToTal.Location = new System.Drawing.Point(433, 332);
            this.lblToTal.Name = "lblToTal";
            this.lblToTal.Size = new System.Drawing.Size(62, 24);
            this.lblToTal.TabIndex = 4;
            this.lblToTal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(501, 293);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 29);
            this.txtSubtotal.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(501, 332);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 6;
            // 
            // mtbData
            // 
            this.mtbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbData.Location = new System.Drawing.Point(686, 293);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(98, 29);
            this.mtbData.TabIndex = 7;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHora
            // 
            this.mtbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHora.Location = new System.Drawing.Point(686, 329);
            this.mtbHora.Mask = "90:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(52, 29);
            this.mtbHora.TabIndex = 8;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHoras.Location = new System.Drawing.Point(623, 332);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(61, 24);
            this.lblHoras.TabIndex = 10;
            this.lblHoras.Text = "Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Location = new System.Drawing.Point(623, 298);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 24);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data:";
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Location = new System.Drawing.Point(396, 24);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.ReadOnly = true;
            this.dgVendas.Size = new System.Drawing.Size(392, 261);
            this.dgVendas.TabIndex = 2;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPagamento.Location = new System.Drawing.Point(524, 385);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(114, 35);
            this.btnPagamento.TabIndex = 11;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblToTal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmVendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.MaskedTextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblToTal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.TextBox txtIDProdutos;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblQuantiade;
        private System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.MaskedTextBox txtID;
        public System.Windows.Forms.MaskedTextBox mtbData;
    }
}