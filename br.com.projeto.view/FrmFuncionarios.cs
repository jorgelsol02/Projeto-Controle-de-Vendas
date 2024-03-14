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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionarios.DataSource = dao.listarFuncionario();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            // botão pesquisar

            string nome = textpesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionarios.DataSource = dao.BuscaFuncionarioPorNome(nome);

            if (tabelaFuncionarios.Rows.Count == 0 || textpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");
                tabelaFuncionarios.DataSource = dao.listarFuncionario();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // botão salvar
            Funcionario obj = new Funcionario();

            // receber os dados dos campos
            obj.nome = textnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = textemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.complemento = textcomplemento.Text;
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();
            obj.cargo = cbcargo.SelectedItem.ToString();

            // Criar o objeto FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            tabelaFuncionarios.DataSource = dao.listarFuncionario();

        }

        private void tabelaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textcodigo.Text = tabelaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            textnome.Text = tabelaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            textemail.Text = tabelaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            textnumero.Text = tabelaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            textcomplemento.Text = tabelaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            textbairro.Text = tabelaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            textcidade.Text = tabelaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelaFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPage1;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // botão excluir

            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(textcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();

            dao.DeletarFuncionario(obj);

            tabelaFuncionarios.DataSource = dao.listarFuncionario();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            // botão editar
            Funcionario obj = new Funcionario();

            // receber os dados dos campos
            obj.nome = textnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = textemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(textnumero.Text);
            obj.complemento = textcomplemento.Text;
            obj.bairro = textbairro.Text;
            obj.cidade = textcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.codigo = int.Parse(textcodigo.Text);

            // Criar o objeto FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(obj);

            tabelaFuncionarios.DataSource = dao.listarFuncionario();

        }

        private void tabelaFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textpesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionarios.DataSource = dao.ListarFuncionarioPorNome(nome);
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
    }
}
