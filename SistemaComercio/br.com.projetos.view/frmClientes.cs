using SistemaComercio.br.com.projetos.dao;
using SistemaComercio.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.br.com.projetos.view
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        #region Novo
        /// <summary>
        /// Botão resposável por limpar a tela de cadastro de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

        #region Editar
        /// <summary>
        /// evento que edita os parametros do cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbEstado.Text;
            cliente.Codigo = int.Parse(txtCodigo.Text);

            // 2 passo - Criar um objeto da classe ClienteDAO para auterar os dados do cliente
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.EditarCliente(cliente);

            // Atualizar o dataGrid view
            dgListaClientes.DataSource = clienteDao.ConsultarClientes();
        }
        #endregion

        #region Excluir
        /// <summary>
        /// Evento que exclui os dados do cliente do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            // Passando o valor do Codigo para o codigo do cliente
            obj.Codigo = int.Parse(txtCodigo.Text);

            // Realizando a Exclusãos do cliente
            ClienteDAO objDao = new ClienteDAO();
            objDao.ExcluirClientes(obj);

            // Atualizar após a deleção
            dgListaClientes.DataSource = objDao.ConsultarClientes();
        }
        #endregion

        #region Salvar
        /// <summary>
        /// Evendo que salva o cliente no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro so objeto modelo de cliente
            Clientes cliente = new Clientes();

            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbEstado.Text;

            // 2 passo - Criar um objeto da classe ClienteDAO
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.CadastrarCliente(cliente);

            dgListaClientes.DataSource = clienteDao.ConsultarClientes();
        }
        #endregion

        #region Load
        /// <summary>
        /// Evento que atualiza os dados do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO obj = new ClienteDAO();
            dgListaClientes.DataSource = obj.ConsultarClientes();
        }
        #endregion

        #region ConsultarNome
        /// <summary>
        /// Evento que pesquisa o cliente dentro do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                string nome = txtNomeConsulta.Text;

                ClienteDAO clienteDao = new ClienteDAO();
                dgListaClientes.DataSource = clienteDao.ListarClienteNome(nome);

                if (dgListaClientes.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
                {
                    dgListaClientes.DataSource = clienteDao.ConsultarClientes();
                }
            }
        }
        #endregion

        #region PesquisarCEP
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
                    MessageBox.Show($"Endereço não encontrado. Por favor digite manualmente!");
                }
            }
        }
        #endregion

        #region dgListaClientes_CellClick
        /// <summary>
        /// Evento que passa os elementos do DataGrid e repassa para a tela de cadastro de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDAO objDao = new ClienteDAO();
            // 1 passo - Pegar os dados da linha selecionada
            txtCodigo.Text = dgListaClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaClientes.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = dgListaClientes.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dgListaClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgListaClientes.CurrentRow.Cells[4].Value.ToString();
            mtbTelefone.Text = dgListaClientes.CurrentRow.Cells[5].Value.ToString();
            mtbCelular.Text = dgListaClientes.CurrentRow.Cells[6].Value.ToString();
            mtbCEP.Text = dgListaClientes.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgListaClientes.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgListaClientes.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgListaClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgListaClientes.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgListaClientes.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgListaClientes.CurrentRow.Cells[13].Value.ToString();

            // 2 passo - Alterar para guia Dados pessoais
            tcClientes.SelectedTab = tabCadastrarCliente;

            // Atualizando o DatagridView
            dgListaClientes.DataSource = objDao.ConsultarClientes();
        }
        #endregion
    }
}
