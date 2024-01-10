using Projeto_Controle_de_Vendas.br.com.projeto.dao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Cliente obj = new Cliente();

            obj.nome = textnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = textemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.complemento = textcomplemento.Text;

            // 2 passo - criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);
            tabelaClientes.DataSource = dao.listarClientes();









        }

        private void tabelaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            tabelaClientes.DataSource = dao.listarClientes();
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabelaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar os dados da linha selecionada
            textcodigo.Text = tabelaClientes.CurrentRow.Cells[0].Value.ToString();
            textnome.Text = tabelaClientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaClientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaClientes.CurrentRow.Cells[3].Value.ToString();
            textemail.Text = tabelaClientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaClientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaClientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaClientes.CurrentRow.Cells[8].Value.ToString();
            textnumero.Text = tabelaClientes.CurrentRow.Cells[9].Value.ToString();
            textcomplemento.Text = tabelaClientes.CurrentRow.Cells[10].Value.ToString();
            textbairro.Text = tabelaClientes.CurrentRow.Cells[11].Value.ToString();
            textcidade.Text = tabelaClientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaClientes.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Cliente obj = new Cliente();

            // pegar o código

            obj.codigo = int.Parse(textcodigo.Text);
            ClienteDAO dao = new ClienteDAO();

            dao.excluirCliente(obj);

            tabelaClientes.DataSource = dao.listarClientes();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Cliente obj = new Cliente();

            obj.nome = textnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = textemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.complemento = textcomplemento.Text;
            obj.codigo = int.Parse(textcodigo.Text);

            // 2 passo - criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            // recarregar datagridview
            tabelaClientes.DataSource = dao.listarClientes();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
             string nome = textpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();
            tabelaClientes.DataSource = dao.BuscarClientePorNome(nome);

            if(tabelaClientes.Rows.Count == 0)
            {
                //recarregar o datagridview
                tabelaClientes.DataSource = dao.listarClientes();
            }
        }

        private void textpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + textpesquisa.Text + "%";


            ClienteDAO dao = new ClienteDAO();
            tabelaClientes.DataSource = dao.ListarClientePorNome(nome);

            
        }

        private void textpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão consultar Cep

            try
            {
                String cep = txtcep.Text;
                String xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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
                } else
                    {
                       MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
                    }
                
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
