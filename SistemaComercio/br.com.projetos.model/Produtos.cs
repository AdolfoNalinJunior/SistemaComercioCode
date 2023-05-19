using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercio.br.com.projetos.model
{
    /// <summary>
    /// Classe modelo Produtos
    /// </summary>
    public class Produtos
    {
        #region Campos
        /// <summary>
        /// Campos da classe Produtos
        /// </summary>
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int CodigoFornecedor { get; set; }
        #endregion
    }
}
