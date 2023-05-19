using SistemaComercio.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercio.br.com.projetos.model
{
    public class Funcionarios : Clientes
    {
        #region Atributos
        /// <summary>
        /// Atributos da classe do obj
        /// </summary>
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string NivelAcesso { get; set; }
        #endregion
    }
}
