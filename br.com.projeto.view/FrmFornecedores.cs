using Projeto_Controle_de_Vendas.br.com.projeto.dao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //Botão consultar Cep

            try
            {
                String cep = txtcep.Text;
                String xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                textbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                textcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                textcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                String cep = txtcep.Text;
                if (cep == null)
                {
                    MessageBox.Show("CEP vazio, preencha o CEP.");
                }
                else
                {
                    MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
                }

            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // botão salvar

            Fornecedor obj = new Fornecedor();
            obj.nome = textnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = textemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.complemento = textcomplemento.Text;
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.Text;

            // criar o objeto da classe FornecedorDAO

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            // Carregar datagrid view de forne
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            //Listar todos os fornecedores

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void tabelaFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textcodigo.Text      = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            textnome.Text        = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text         = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            textemail.Text       = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text     = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text      = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text          = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text     = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            textnumero.Text      = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            textcomplemento.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            textbairro.Text      = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            textcidade.Text      = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text            = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabFornecedores.SelectedTab = tabPage1;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // botão alterar

            Fornecedor obj = new Fornecedor();
            obj.nome = textnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = textemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.complemento = textcomplemento.Text;
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.Text;


            obj.codigo = int.Parse(textcodigo.Text);
            // criar o objeto da classe FornecedorDAO

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);

            // Carregar datagrid view de forne
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // botão excluir

            Fornecedor obj = new Fornecedor();
           

            obj.codigo = int.Parse(textcodigo.Text);
            // criar o objeto da classe FornecedorDAO

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(obj);

            // Carregar datagrid view de forne
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = textpesquisa.Text;

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedores.Rows.Count == 0)
            {
                //recarregar o datagridview
                MessageBox.Show("Fornecedor " + nome + " não encontrado.");
                tabelaFornecedores.DataSource = dao.listarFornecedores();
            }
        }

        private void textpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textpesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.listarFornecedoresPornome(nome);
        }
    }
}
