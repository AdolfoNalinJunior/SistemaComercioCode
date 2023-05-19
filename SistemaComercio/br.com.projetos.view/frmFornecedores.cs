using Org.BouncyCastle.Crypto.Engines;
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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        #region PesquisaCEP
        /// <summary>
        /// Evento que pesquisa o cep após o click no enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string cep = mtbCEP.Text;
                    string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml";
                    DataSet dado = new DataSet();
                    dado.ReadXml(xmlUrl);

                    txtEndereco.Text = dado.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dado.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = dado.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplemento.Text = dado.Tables[0].Rows[0]["complemento"].ToString();
                    cbEstado.Text = dado.Tables[0].Rows[0]["uf"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"O CEP digitado não foi encontrado! Por favor, digite-o manualmente!");
                }
            }
        }

        #endregion

        #region btnNovo
        /// <summary>
        /// Evento que limpa todos os campos da tabCadastrarFornecedores, para receber um novo fornecedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

        #region btnSalvar
        /// <summary>
        /// Evento que salva o fornecedor no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = Convert.ToInt16(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.CadastrarFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region Load
        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedoresDAO obj = new FornecedoresDAO();
            dgListaFornecedor.DataSource = obj.ConsultarFornecedores();
        }
        #endregion

        #region Transferência de dados
        /// <summary>
        /// Evento que tranfere os dados do dgListarFornecedor para o tabCadastrarForcedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgListaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgListaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaFornecedor.CurrentRow.Cells[1].Value.ToString();
            mtbCNPJ.Text = dgListaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgListaFornecedor.CurrentRow.Cells[3].Value.ToString();
            mtbTelefone.Text = dgListaFornecedor.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgListaFornecedor.CurrentRow.Cells[5].Value.ToString();
            mtbCEP.Text = dgListaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = dgListaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = dgListaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = dgListaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = dgListaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = dgListaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbEstado.Text = dgListaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tcFornecedores.SelectedTab = tabCadastrarFornecedores;
        }
        #endregion

        #region btnEditar
        /// <summary>
        /// Evento que edita o fornecedor no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.EditarFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region Excluir
        /// <summary>
        /// Evento que exclui o fornecedor do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.ExcluirFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region KeyPress
        /// <summary>
        /// Evento que pesquisa o fornecedor de acordo com a digitação do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNomeConsulta.Text + '%';

            FornecedoresDAO obj = new FornecedoresDAO();
            dgListaFornecedor.DataSource = obj.ListarFornecedoresNome(nome);

            if (dgListaFornecedor.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                dgListaFornecedor.DataSource = obj.ConsultarFornecedores();
            }
        }
        #endregion
    }
}
