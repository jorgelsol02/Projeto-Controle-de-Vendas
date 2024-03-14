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
    public class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }




        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {

            try
            {
                // 1 passo - definir o comando sql - insert into
                String sql = @"insert into tb_clientes(nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values(@nome, @rg, @cpf, @email, @telefone, @celular,@cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2 passo - organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente Cadastrado com Sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: "+ erro);

            }

        }
        #endregion

        #region alterarCliente

        public void alterarCliente(Cliente obj)
        {

            try
            {
                // 1 passo - definir o comando sql - insert into
                String sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,
                            endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                            where id=@id";
                               

                // 2 passo - organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passso - abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }



        #endregion

        
        #region excluirCliente
        public void excluirCliente(Cliente obj)
        {

            try
            {
                // 1 passo - definir o comando sql - insert into
                String sql = @"delete from tb_clientes where id = @id";


                // 2 passo - organizar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passso - abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }


        #endregion

        #region listarCliente
        public DataTable listarClientes()
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaCliente = new DataTable();

                string sql = @"select c.id as 'Código',
                               c.nome as 'Nome',
		                       c.rg as 'RG',
		                       c.cpf as 'CPF',
		                       c.email as 'Email',
		                       c.telefone as 'Telefone',
		                       c.celular as 'Celular',
		                       c.cep as 'Cep',
		                       c.endereco as 'Endereço',
		                       c.numero as 'Número',
		                       c.complemento as 'Complemento',
		                       c.bairro as 'Bairro',
		                       c.cidade as 'Cidade',
		                       c.estado as 'Estado'from tb_clientes as c;";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion


        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaCliente = new DataTable();

                string sql = "select * from tb_clientes where nome = @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaCliente);

                return tabelaCliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion


        #region ListarClientePorNome
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaCliente = new DataTable();

                string sql = "select * from tb_clientes where nome like @nome";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaCliente);

                return tabelaCliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion

        #region Método que retorna um cliente por CPF

        public Cliente retornaClientePorCPF(string cpf)
        {
            try
            {
                // 1 passo - Criar o comando sql e o objeto cliente

                Cliente obj = new Cliente();
                string sql = @"select *from tb_clientes where cpf = @cpf";

                //2 passo - organizar o comando sql e executar
                

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);
                executacdm.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                MySqlDataReader rs = executacdm.ExecuteReader();
                if (rs.Read())
                {
                    obj.codigo = rs.GetInt32("id");
                    obj.nome = rs.GetString("nome");

                    conexao.Close();
                    return obj;
                }
                else 
                {
                    MessageBox.Show("Cliente não encontrado.");

                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: +" + erro);
                return null;
            }
        }

        #endregion
    }

}

