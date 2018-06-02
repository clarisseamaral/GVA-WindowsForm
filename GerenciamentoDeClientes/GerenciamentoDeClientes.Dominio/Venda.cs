using System;

namespace GerenciamentoDeClientes.Dominio
{
    public class Venda
    {
        public int Codigo { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime DataVenda { get; set; }

        public DateTime? DataPagamento { get; set; }

        public DateTime DataVencimento { get; set; }

        public string Descricao { get; set; }

        public double ValorTotal { get; set; }
    }
}
