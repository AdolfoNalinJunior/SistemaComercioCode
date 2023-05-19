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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        #region btnNovo
        /// <summary>
        /// Evento que limpa o tabCadastrarFuncionario
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
        /// Evento Salvar obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF = mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbEstado.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.CadastrarFuncionario(funcionario);

            dgListaFuncionarios.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region Load
        /// <summary>
        /// Evento de inicialização da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO obj = new FuncionarioDAO();
            dgListaFuncionarios.DataSource = obj.ConsultarFuncionario();
        }

        #endregion

        #region Transferência de dados para a tabCadastrarFuncionario
        /// <summary>
        /// Evento que transfere todos os recursos para a tabCadastrarFuncionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgListaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgListaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = dgListaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dgListaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgListaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgListaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgListaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbNivelAcesso.Text = dgListaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            mtbTelefone.Text = dgListaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            mtbCelular.Text = dgListaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            mtbCEP.Text = dgListaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgListaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgListaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgListaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgListaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgListaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = dgListaFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tcFuncionario.SelectedTab = tabCadastrarFuncionario;
        }
        #endregion

        #region btnExcluir
        /// <summary>
        /// Evento que exclui o obj do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.ExcluirFuncionario(obj);

            dgListaFuncionarios.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region btnEditar
        /// <summary>
        /// Evento que edita um obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.Codigo = int.Parse(txtCodigo.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF = mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbEstado.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.EditarFuncionario(funcionario);

            dgListaFuncionarios.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string nome = '%' + txtNomeConsulta.Text + '%';

                FuncionarioDAO dao = new FuncionarioDAO();

                dgListaFuncionarios.DataSource = dao.BuscarFuncionarioNome(nome);

                if (dgListaFuncionarios.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
                {
                    MessageBox.Show("Funcionário não encontrado! Certifique-se se o nome do Funcionário está cadastrado ou se está escrito corretamente!");
                    dgListaFuncionarios.DataSource = dao.ConsultarFuncionario();
                }
            }
        }

        #region CEP_KeyPress
        /// <summary>
        /// Evento que atualiza o DataGrid de acordo com o que o usuário digita
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
                    MessageBox.Show($"Endereço não encontrado. Por favor digite manualmente!");
                }
            }
        }
        #endregion
    }
}
