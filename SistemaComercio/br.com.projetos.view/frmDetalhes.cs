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
    public partial class frmDetalhes : Form
    {
        int idVenda;

        public frmDetalhes(int id)
        {
            idVenda = id;
            InitializeComponent();
        }

        private void frmDetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO objDao = new ItemVendaDAO();
            dgDetalhes.DataSource = objDao.ListarItemVenda(idVenda);
        }
    }
}
