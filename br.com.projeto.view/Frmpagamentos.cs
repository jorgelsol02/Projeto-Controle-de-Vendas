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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();

        public Frmpagamentos(Cliente cliente, DataTable carrinho)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelpreco_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
