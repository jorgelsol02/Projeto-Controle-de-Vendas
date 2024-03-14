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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void txtcodigo_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "Código";

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.listarProdutos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor do combobox: " + cbfornecedor.SelectedValue);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // 1 passo receber os dados da tela

            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            //2 passo - criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastraProduto(obj);

            new Helpers().LimparTela(this);

            // recarregar datagridview

            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegando os dados de um produto selecionado

            txtcodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            // alterar para a guia dados pessoais

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // botão editar produto

            // 1 passo receber os dados da tela

            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtcodigo.Text);

            //2 passo - criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);

            new Helpers().LimparTela(this);

            // recarregar datagridview

            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // botão editar produto

            // 1 passo receber os dados da tela

            Produto obj = new Produto();

            
            obj.id = int.Parse(txtcodigo.Text);

            //2 passo - criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);

            new Helpers().LimparTela(this);

            // recarregar datagridview

            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void textpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textpesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.listarProdutosPorNome(nome);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            // botão pesquisar

            string nome = textpesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.buscarProdutoPorNome(nome);

            if (tabelaProdutos.Rows.Count == 0 || textpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Produto não encontrado!");
                tabelaProdutos.DataSource = dao.listarProdutos();
            }
        }
    }
    }

