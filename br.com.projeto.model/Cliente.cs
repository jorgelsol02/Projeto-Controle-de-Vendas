using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class Cliente
    {

        // prop tab tab
        public int codigo { get; set; }
        public String nome { get; set; }
        public String rg { get; set; }
        public String cpf { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public String cep { get; set; }

        public String endereco { get; set; }
        public String email { get; set; }

        public int numero { get; set; }

        public String complemento { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }



    }
}