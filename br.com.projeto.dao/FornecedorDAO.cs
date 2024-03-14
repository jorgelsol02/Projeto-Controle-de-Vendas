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
    public class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }


        #region Cadastrar Fornecedor
        public void cadastrarFornecedor(Fornecedor obj)
        {

            try
            {
                // 1 passo - definir o comando sql - insert into
                String sql = @"insert into tb_fornecedores(nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values(@nome,@cnpj, @email, @telefone, @celular,@cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2 passo - organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passso - abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }


        #endregion

        #region Método que lista todos os fornecedores
        public DataTable listarFornecedores()
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaFornecedores = new DataTable();

				string sql = @"select f.id as 'Código',
                             f.nome as 'Nome',
							 f.cnpj as 'CNPJ',
							 f.email as 'Email',
							 f.telefone as 'Telefone',
							 f.celular as 'Celular',
							 f.cep as 'Cep',
							 f.endereco as 'Endereço',
							 f.numero as 'Número',
							 f.complemento as 'Complemento',
						     f.bairro as 'Bairro',
						     f.cidade as 'Cidade',
						     f.estado as 'Estado' from tb_fornecedores as f;";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaFornecedores);

                conexao.Close();

                return tabelaFornecedores;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }


        #endregion


        #region Alterar Fornecedor

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {

                //1 passo - criar o comando sql


                string sql = @"update tb_fornecedores set nome = @nome,cnpj = @cnpj, email = @email, telefone = @telefone,
                                                                 celular = @celular, cep = @cep, endereco = @endereco, numero = @numero,
                                                                 complemento = @comp, bairro = @bairro,cidade = @cidade,estado = @estado where id = @id";

                //2 passo - organiuzar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@comp", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion


        #region Excluir Fornecedor
        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 passo - Criar o comando sql
                string sql = @"delete from tb_fornecedores where id = @id";

                //2 passo - Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluido com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }

        #endregion

        #region Método que lista todos os fornecedores por nome
        public DataTable listarFornecedoresPornome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaFornecedores = new DataTable();

                string sql = "select * from tb_fornecedores where nome like @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaFornecedores);

                conexao.Close();

                return tabelaFornecedores;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }


        #endregion

        #region Método que busca um fornecedores por nome
        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaFornecedores = new DataTable();

                string sql = "select * from tb_fornecedores where nome = @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaFornecedores);

                conexao.Close();

                return tabelaFornecedores;


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
