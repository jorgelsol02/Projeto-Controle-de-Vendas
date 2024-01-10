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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }


        #region Cadastrar Funcionario
        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 passo - Criar o comando sql
                string sql = "insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)" +
                    " values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // 2 passo - Organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
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

                MessageBox.Show("Funcionário Cadastrado com Sucesso");

                // fechar a conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: "+ erro);
            }
        }



        #endregion

        #region Método ListarFuncionários
        public DataTable listarFuncionario()
        {
            try
            {
                // 1 passo - criar o Datatable e o comando sql
                DataTable tabelaFuncionario = new DataTable();

                string sql = "select * from tb_funcionarios";

                // 2 passo - Organizar o sql e executar

                MySqlCommand executacdm = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacdm.ExecuteNonQuery();

                // 3 passo - Criar o MySQLDataAdapter para preencher os dados do DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacdm);
                da.Fill(tabelaFuncionario);

                return tabelaFuncionario;


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
