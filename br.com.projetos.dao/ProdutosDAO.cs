﻿using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    public class ProdutosDAO
    {
        #region Connection 
        private MySqlConnection connection;
        #endregion

        #region ProdutoDAO
        public ProdutosDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarProdutos
        public void CadastrarProdutos(Produtos obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
values(@descricao,@preco,@qtd_estoque,@for_id)";
                
                MySqlCommand cmdSql = new MySqlCommand(sql,connection);
                cmdSql.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmdSql.Parameters.AddWithValue("@preco", obj.Preco);
                cmdSql.Parameters.AddWithValue("@qtd_estoque", obj.Estoque);
                cmdSql.Parameters.AddWithValue("@for_id", obj.CodigoFornecedor);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"Produto foi cadastrado com sucesso ");


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do Tipo {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarProdutos
        public DataTable ConsultarProdutos()
        {
            try
            {
                DataTable tabProduto = new DataTable();

                string sql = @"select  p.id as 'Código',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Quantidade Estoque',
                                f.nome as 'Fornecedores' 
                                from bdvendas.tb_produtos as p join bdvendas.tb_fornecedores as f
                                on (p.for_id = f.id)";

                MySqlCommand cmd = new MySqlCommand( sql,connection);
                
                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProduto);

                connection.Close();  
                return tabProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region EditarProduto
        public void EditarProduto(Produtos obj)
        {
            try
            {

                string sql = "update bdvendas.tb_produtos set descricao=@descricao,preco=@preco,qtd_estoque=@qtd_estoque,for_id=@for_id where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql,connection);
                
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@preco", obj.Preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.Estoque);
                cmd.Parameters.AddWithValue("@for_id", obj.CodigoFornecedor);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"O produto {obj.Descricao} foi editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminnho para {ex.StackTrace}");
            }
            
        }
        #endregion

        #region ExcluirProduto
        public void ExcluirProduto(Produtos obj)
        {
            try
            {
                string sql = "delete from bdvendas.tb_produtos where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto foi excluido com sucesso!");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region BuscarNome
        public DataTable BuscarProduto(string nome)
        {
            try
            {
                DataTable tabProdutos = new DataTable();
                string sql = "select * from bdvendas.tb_produtos where descricao = @descricao";

                MySqlCommand cmd = new MySqlCommand( sql, connection);
                cmd.Parameters.AddWithValue("@descricao", nome);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProdutos);

                connection.Close();

                return tabProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ListarProdutoNome
        public DataTable ListarProdutoNome(string nome)
        {
            try
            {
                DataTable tabProdutos = new DataTable();
                string sql = "select * from bdvendas.tb_produtos where descricao like @descricao";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@descricao", nome);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProdutos);

                connection.Close();
                return tabProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region BuscarProdutoVenda
        public Produtos BuscarProdutoVenda(int id)
        {
            try
            {
                Produtos obj = new Produtos();
                string sql = "select * from bdvendas.tb_produtos where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    obj.Codigo = dr.GetInt32("id");
                    obj.Descricao = dr.GetString("descricao");
                    obj.Preco = dr.GetDecimal("preco");
                    obj.Estoque = dr.GetInt32("qtd_estoque");

                    connection.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show($"Por favor digite um código válido!");
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ControlarEstoque
        public void ControlarEstoque(int idProduto, int estoque)
        {
            try
            {
                string sql = "update tb_produtos set qtd_estoque = @estoque where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@estoque", estoque);
                cmd.Parameters.AddWithValue("@id", idProduto);
                    
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region RetornarEstoque
        public int RetornarEstoque(int id)
        {
            try
            {
                string sql = "select qtd_estoque from tb_produtos where id = @id";
                int estoqueSaida = 0;

                MySqlCommand cmd = new MySqlCommand( sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    estoqueSaida = DR.GetInt32("qtd_estoque");
                    connection.Close();
                }

                return estoqueSaida;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com a mensagem {ex.StackTrace}");
                connection.Close();
                return 0;
            }
        }

        #endregion
    }
}
