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
        public Frmvendas()
        {
            InitializeComponent();
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
    }
}
