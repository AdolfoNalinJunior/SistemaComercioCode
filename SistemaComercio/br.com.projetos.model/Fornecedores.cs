using SistemaComercio.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercio.br.com.projetos.model
{
    public class Fornecedores : Clientes
    {
        #region Campos
        /// <summary>
        /// Campos da classe
        /// </summary>
        public string CNPJ { get; set; }
        #endregion
    }
}
