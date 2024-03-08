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
    public partial class Frmvendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        // objetos de produto

        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        //Variaveis

        int qtd;
        decimal preco;
        decimal subtotal, total;

        //carrinho

        DataTable carrinho = new DataTable();

        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço Unitário", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_Click(object sender, EventArgs e)
        {

        }

        private void quantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCPF(txtcpf.Text);

                txtnome.Text = cliente.nome;
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.retornaProdutoPorCodigo(int.Parse(txtcodigo.Text));

                txtdesc.Text = p.descricao;
                txtpreco.Text = p.preco.ToString();

            }
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtqtd.Text);
            preco = decimal.Parse(txtpreco.Text);
            subtotal = qtd * preco;

            total += subtotal;

            // adicionar o produto no carrinho

            carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);

            txttotal.Text = total.ToString();

            // limpar os campos

            txtcodigo.Clear();
            txtdesc.Clear();
            txtqtd.Clear();
            txtpreco.Clear();

            txtcodigo.Focus();

        }
    }
}
