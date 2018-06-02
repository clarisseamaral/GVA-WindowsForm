using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClientes.Dominio
{
    public class FiltroTelaVendas
    {
        public int Codigo { get; set; }

        public int CodigoCliente { get; set; }

        public DateTime? DataInicial { get; set; }

        public DateTime? DataFinal { get; set; }

        public string Descricao { get; set; }

        public int Status { get; set; }

    }
}
