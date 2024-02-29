using MySql.Data.MySqlClient;
using Projeto_Controle_de_Vendas.br.com.projeto.conexao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.dao
{
    public class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO() 
        {
            this.conexao = new ConnectionFactory().Getconnection();
        }

        #region Método Cadastrar Produto
        public void cadastraProduto (Produto obj) 
        {
            try
            {
                // 1 passo - Criar SQL

                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                                values (@descricao, @preco, @qtd, @for_id)";

                // 2 passo - Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                // 3 passo - abrir a conexão e executar o comando

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: "+ erro);
            }
        
        }


        #endregion

        #region Método Listar Produtos
        public DataTable listarProdutos()
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaProduto = new DataTable();

                string sql = @"select 
		                        p.id as 'Código', 
		                        p.descricao as 'Descição', 
		                        p.preco as 'Preço', 
                                p.qtd_estoque as 'Qtd Estoque', 
                                f.nome as 'Fornecedor' from tb_produtos as p
	                            join tb_fornecedores as f on (p.for_id = f.id);";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }


        #endregion

        #region Método Alterar Produto
        public void alterarProduto(Produto obj)
        {
            try
            {
                // 1 passo - Criar SQL

                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd, for_id=@for_id 
                            where id = @id";

                // 2 passo - Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                // 3 passo - abrir a conexão e executar o comando

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion

        #region Excluir Produto
        public void excluirProduto(Produto obj)
        {
            try
            {
                // 1 passo - Criar SQL

                string sql = @"delete from tb_produtos where id = @id";

                // 2 passo - Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                // 3 passo - abrir a conexão e executar o comando

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion


        #region Listar Produto por nome
        public DataTable listarProdutosPorNome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaProduto = new DataTable();

                string sql = @"select 
		                        p.id as 'Código', 
		                        p.descricao as 'Descição', 
		                        p.preco as 'Preço', 
                                p.qtd_estoque as 'Qtd Estoque', 
                                f.nome as 'Fornecedor' from tb_produtos as p
	                            join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }
        #endregion

        #region Buscar Produto
        public DataTable buscarProdutoPorNome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaProduto = new DataTable();

                string sql = @"select 
		                        p.id as 'Código', 
		                        p.descricao as 'Descição', 
		                        p.preco as 'Preço', 
                                p.qtd_estoque as 'Qtd Estoque', 
                                f.nome as 'Fornecedor' from tb_produtos as p
	                            join tb_fornecedores as f on (p.for_id = f.id) where p.descricao = @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }
        #endregion
    }
}
