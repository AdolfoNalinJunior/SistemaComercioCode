using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.br.com.projetos.view
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region objetos
        /// <summary>
        /// Objetos pré instânciados
        /// </summary>
        frmClientes clientesT = new frmClientes();
        frmFuncionario funcT = new frmFuncionario();
        frmFornecedores fornecedoresT = new frmFornecedores();
        frmProdutos produtosT = new frmProdutos();
        frmHistorico historicosT = new frmHistorico();
        frmVendas vendasT = new frmVendas();
        #endregion

        #region ConsultarClienteMenu
        /// <summary>
        /// Evento que abre o cadastro de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientesT.tcClientes.SelectedTab = clientesT.tabConsultarClientes;
            clientesT.ShowDialog();
        }
        #endregion

        #region CadastrarCLienteMenu
        /// <summary>
        /// Evento que abre a tela de Consulta cliente no menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientesT.tcClientes.SelectedTab = clientesT.tabCadastrarCliente;
            clientesT.ShowDialog();
        }
        #endregion

        #region CosultarForncedoresMenu
        /// <summary>
        /// Evento que abre a Consulta de Forncedores no menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedoresT.tcFornecedores.SelectedTab = fornecedoresT.tabConsultarClientes;
            fornecedoresT.ShowDialog();
        }
        #endregion

        #region CadastrarFornecedores
        /// <summary>
        /// evento que abre a tela de Cadastrar Forncedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedoresT.tcFornecedores.SelectedTab = fornecedoresT.tabCadastrarFornecedores;
            fornecedoresT.ShowDialog();
        }
        #endregion

        #region ConsultarProdutoMenu
        /// <summary>
        /// Evento que abre a tela de Consulta de produtos no menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtosT.tcProduto.SelectedTab = produtosT.tabConsultarProdutos;
            produtosT.ShowDialog();
        }
        #endregion

        #region CadastrarProdutosMenu
        /// <summary>
        /// Evento que abre a tela de Cadastro de Produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtosT.tcProduto.SelectedTab = produtosT.tabCadastrarProdutos;
            produtosT.ShowDialog();
        }
        #endregion

        #region TelaVendaMenu
        /// <summary>
        /// Evento que abre a tela de vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void telaDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendasT.ShowDialog();
        }

        #endregion

        #region HistoricoVendaMenu
        /// <summary>
        /// Evento que abre a tela de Histórico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void históricosDeVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historicosT.ShowDialog();
        }
        #endregion

        #region ConsultarFuncionarioMenu
        /// <summary>
        /// Evento que abre a tela de consulta de funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcT.tcFuncionario.SelectedTab = funcT.tabConsultarFuncionario;
            funcT.ShowDialog();
        }
        #endregion

        #region CadastrarFuncionarioMenu
        /// <summary>
        /// Evento que abre a tela de cadastrar funcionario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarFuncionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            funcT.tcFuncionario.SelectedTab = funcT.tabCadastrarFuncionario;
            funcT.ShowDialog();
        }
        #endregion

        #region SairDoSistemaMenu
        /// <summary>
        /// Evento que sai do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reult = MessageBox.Show("Você deseja mesmo SAIR?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(reult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
