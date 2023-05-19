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
    public partial class frmPagamentos : Form
    {
        #region Componentes da classe
        Clientes obj = new Clientes();
        DataTable carrinho = new DataTable();
        Vendas vendas = new Vendas();
        DateTime dataAtual = DateTime.Parse(DateTime.Now.ToLongDateString());
        DateTime horaAtual = DateTime.Parse(DateTime.Now.ToLongTimeString());
        #endregion

        #region ConstrutorParametros
        /// <summary>
        /// Construtor com parametros de carrinho
        /// </summary>
        /// <param name="cliente">Parametros Clientes</param>
        /// <param name="carrinho">Parametros Carrinho</param>
        public frmPagamentos(Clientes cliente, DataTable carrinho)
        {
            this.obj = cliente;
            this.carrinho = carrinho;

            InitializeComponent();
        }
        #endregion

        #region Load
        /// <summary>
        /// Tela de pagamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPagamentos_Load(object sender, EventArgs e)
        {
            double num = 0.00;
            txtDinheiro.Text = String.Format("{0:0.00}", num);
            txtCartao.Text = String.Format("{0:0.00}", num);
            txtCrediario.Text = String.Format("{0:0.00}", num);
            txtPix.Text = String.Format("{0:0.00}", num);
        }

        #endregion

        #region btnFinalizar
        /// <summary>
        /// Evento que finaliza a venda e salva os itens no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dinheiro, cartao, troco, totalPago, total;
                int estoque, compra, estoqueAtual;

                ProdutosDAO pDao = new ProdutosDAO();

                dinheiro = decimal.Parse(txtDinheiro.Text);
                cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                totalPago = dinheiro + cartao;

                if (totalPago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda");
                }
                else
                {
                    troco = totalPago - total;
                    txtTroco.Text = troco.ToString();

                    Vendas vendas = new Vendas();
                    vendas.CodigoCliente = obj.Codigo;
                    vendas.Data = dataAtual;
                    vendas.Hora = dataAtual;
                    vendas.TotalVenda = total;
                    vendas.Observacao = txtObs.Text;

                    txtTroco.Text = troco.ToString();

                    VendasDAO vDao = new VendasDAO();
                    vDao.CadastrarVenda(vendas);

                    foreach (DataRow linha in carrinho.Rows)
                    {

                        ItemVendas item = new ItemVendas();
                        item.CodigoVenda = vDao.ultimaVenda();
                        item.CodigoProduto = int.Parse(linha["Código"].ToString());
                        item.Quantidade = int.Parse(linha["Quantidade"].ToString());
                        item.Subtotal = decimal.Parse(linha["SubTotal"].ToString());

                        estoque = pDao.RetornarEstoque(item.CodigoProduto);
                        compra = item.Quantidade;

                        estoqueAtual = estoque - compra;

                        pDao.ControlarEstoque(item.CodigoProduto, estoqueAtual);

                        ItemVendaDAO iDao = new ItemVendaDAO();
                        iDao.CadastrarItemVenda(item);
                        this.Hide();

                    }

                    MessageBox.Show("Venda cadastrada com sucesso!!!");
                    Dispose();
                    new frmVendas().ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region btnCancelar
        /// <summary>
        /// Cancela fecha tela frmPagamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion
    }
}
