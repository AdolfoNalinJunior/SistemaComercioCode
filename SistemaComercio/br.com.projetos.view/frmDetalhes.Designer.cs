namespace SistemaComercio.br.com.projetos.view
{
    partial class frmDetalhes
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
            this.dgDetalhes = new System.Windows.Forms.DataGridView();
            this.gbDadosVenda = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblOberservacao = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhes)).BeginInit();
            this.gbDadosVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDetalhes
            // 
            this.dgDetalhes.AllowUserToAddRows = false;
            this.dgDetalhes.AllowUserToDeleteRows = false;
            this.dgDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalhes.Location = new System.Drawing.Point(15, 137);
            this.dgDetalhes.Name = "dgDetalhes";
            this.dgDetalhes.ReadOnly = true;
            this.dgDetalhes.Size = new System.Drawing.Size(773, 306);
            this.dgDetalhes.TabIndex = 1;
            // 
            // gbDadosVenda
            // 
            this.gbDadosVenda.Controls.Add(this.txtCodigo);
            this.gbDadosVenda.Controls.Add(this.lblId);
            this.gbDadosVenda.Controls.Add(this.txtPreco);
            this.gbDadosVenda.Controls.Add(this.lblPreco);
            this.gbDadosVenda.Controls.Add(this.txtData);
            this.gbDadosVenda.Controls.Add(this.lblData);
            this.gbDadosVenda.Controls.Add(this.txtObs);
            this.gbDadosVenda.Controls.Add(this.lblOberservacao);
            this.gbDadosVenda.Controls.Add(this.txtCliente);
            this.gbDadosVenda.Controls.Add(this.lblCliente);
            this.gbDadosVenda.Location = new System.Drawing.Point(15, 12);
            this.gbDadosVenda.Name = "gbDadosVenda";
            this.gbDadosVenda.Size = new System.Drawing.Size(773, 119);
            this.gbDadosVenda.TabIndex = 2;
            this.gbDadosVenda.TabStop = false;
            this.gbDadosVenda.Text = "Dados da Venda";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCodigo.Location = new System.Drawing.Point(667, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(72, 22);
            this.txtCodigo.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblId.Location = new System.Drawing.Point(584, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(77, 16);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Cd. venda";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPreco.Location = new System.Drawing.Point(499, 56);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(72, 22);
            this.txtPreco.TabIndex = 13;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPreco.Location = new System.Drawing.Point(449, 59);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(52, 16);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtData.Location = new System.Drawing.Point(499, 16);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(72, 22);
            this.txtData.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Location = new System.Drawing.Point(449, 18);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 16);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtObs.Location = new System.Drawing.Point(111, 63);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(332, 39);
            this.txtObs.TabIndex = 9;
            // 
            // lblOberservacao
            // 
            this.lblOberservacao.AutoSize = true;
            this.lblOberservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOberservacao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOberservacao.Location = new System.Drawing.Point(20, 63);
            this.lblOberservacao.Name = "lblOberservacao";
            this.lblOberservacao.Size = new System.Drawing.Size(96, 16);
            this.lblOberservacao.TabIndex = 8;
            this.lblOberservacao.Text = "Observação:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCliente.Location = new System.Drawing.Point(110, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(332, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCliente.Location = new System.Drawing.Point(49, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDadosVenda);
            this.Controls.Add(this.dgDetalhes);
            this.Name = "frmDetalhes";
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.frmDetalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhes)).EndInit();
            this.gbDadosVenda.ResumeLayout(false);
            this.gbDadosVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgDetalhes;
        private System.Windows.Forms.GroupBox gbDadosVenda;
        private System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        public System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblOberservacao;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblId;
    }
}