using SistemaComercio.br.com.projetos.dao;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region btnEntrar_Click
        /// <summary>
        /// Evento que executa a função logar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            if(objDao.Logar(email, senha))
            {
                //frmMenu menuT = new frmMenu();
                //menuT.Show();
                this.Hide();
            }
         }
        #endregion
    }
}
