using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercio.br.com.projetos.connection
{
    /// <summary>
    /// Classe responsavel pela conecxão do banco de dados
    /// </summary>
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
