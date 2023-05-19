using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercio.br.com.projetos.model
{
    public class ItemVendas
    {
        #region Campos
        public int Codigo { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }
        #endregion
    }
}
