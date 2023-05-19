using SistemaComercio.br.com.projetos.dao;
using SistemaComercio.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.br.com.projetos.view
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        #region Variaveis da classe
        /// <summary>
        /// Variáveis de manipulação
        /// </summary>
        int quantidade = 0;
        int quantidadeTotal = 0;
        decimal preco = 0;
        decimal subtotal = 0;
        decimal total = 0;
        #endregion

        #region Objs
        /// <summary>
        /// Obj de manipulação
        /// </summary>
        Clientes clientes = new Clientes();
        ClienteDAO cDao = new ClienteDAO();
        DataTable carrinho = new DataTable();
        #endregion

        #region load
        /// <summary>
        /// Tela de vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVendas_Load(object sender, EventArgs e)
        {
            double num = 0.00;
            txtSubtotal.Text = String.Format("{0:0.00}", num);
            txtTotal.Text = String.Format("{0:0.00}", num);

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            dgVendas.DataSource = carrinho;

            // Configuração da data
            mtbData.Text = DateTime.Now.ToShortDateString();
            mtbHora.Text = DateTime.Now.ToShortTimeString();

            mtbCPF.Focus();
        }
        #endregion

        #region mtbCPF_KeyPress
        /// <summary>
        /// Evento que atualiza o DataGrid de acordo com o que o usuário digita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                clientes = cDao.BuscarClienteVendas(mtbCPF.Text);

                if (clientes != null)
                {
                    txtNome.Text = clientes.Nome;
                    txtID.Text = clientes.Codigo.ToString();
                    txtEndereco.Text = $"{clientes.Endereco}, {clientes.Numero.ToString()}, {clientes.Bairro}";
                }
                else
                {
                    mtbCPF.Clear();
                    mtbCPF.Focus();
                }
            }
        }

        #endregion

        #region btnAdd_Click
        /// <summary>
        /// evento que adiciona o produto no dgVenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                quantidade = int.Parse(txtQuantidade.Text);
                preco = decimal.Parse(txtPreco.Text);
                subtotal = quantidade * preco;


                total += subtotal;
                txtSubtotal.Text = subtotal.ToString();
                txtTotal.Text = total.ToString();

                quantidadeTotal += quantidade;

                carrinho.Rows.Add(int.Parse(txtIDProdutos.Text), txtDescricao.Text, quantidade, preco, subtotal);

                txtIDProdutos.Clear();
                txtDescricao.Clear();   
                txtQuantidade.Clear();
                txtEstoque.Clear();
                txtPreco.Clear();

                txtIDProdutos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Por favor digite um código válido, ou verifique se existe uma quantidade do prudoto desejado");
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region btnRemover
        /// <summary>
        /// Evento que deleta o produto do dgVenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal subProduto = decimal.Parse(dgVendas.CurrentRow.Cells[4].Value.ToString());
            /*
             * A variável está selecionando o valor de subtotal da linha selecionada
             * Para conseguir manipular no evento btnRmProduto_Click
             */

            int indice = dgVendas.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subProduto;

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }
        #endregion

        #region txtProduto_KeyPress
        /// <summary>
        /// Evento que pesquisa o produto de acordo com o que o usuário pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Produtos produtos = new Produtos();
            ProdutosDAO objDAO = new ProdutosDAO();

            if (e.KeyChar == 13)
            {
                produtos = objDAO.BuscarProdutoVenda(int.Parse(txtIDProdutos.Text));

                if (produtos != null)
                {
                    txtIDProdutos.Text = produtos.Codigo.ToString();
                    txtDescricao.Text = produtos.Descricao;
                    txtPreco.Text = produtos.Preco.ToString();
                    txtEstoque.Text = produtos.Estoque.ToString();
                    txtTotal.Text = produtos.Preco.ToString();
                }
                else
                {
                    txtID.Clear();
                    txtID.Focus();
                }
            }
        }
        #endregion

        #region btnPagamento
        /// <summary>
        /// Evento que que confirma os dados para o pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                frmPagamentos pg = new frmPagamentos(clientes, carrinho);
                Vendas obj = new Vendas();
                obj.CodigoCliente = int.Parse(txtID.Text);
                obj.Data = DateTime.Parse(DateTime.Now.ToLongDateString());
                obj.TotalVenda = decimal.Parse(txtTotal.Text);
                obj.Observacao = pg.txtObs.Text;

                VendasDAO objDao = new VendasDAO();
                objDao.CadastrarVenda(obj);

                pg.txtTotal.Text = txtTotal.Text;
                pg.txtSubtotal.Text = txtSubtotal.Text;
                pg.ShowDialog();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}");
            }
        }
        #endregion

    }
}
