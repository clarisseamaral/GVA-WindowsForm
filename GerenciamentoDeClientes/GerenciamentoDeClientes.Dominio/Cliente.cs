using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClientes.Dominio
{
    public class Cliente
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Sexo { get; set;  }

        public string CEP { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string UF { get; set; }

        public string Observacoes { get; set; }

    }
}
