
namespace GerenciamentoDeClientes.Dominio
{
    public class GraficoClientes
    {

        public GraficoClientes() { }

        public GraficoClientes(string nomeCliente, int quantidadeCompras, double valorComprado)
        {
            this.NomeCliente = nomeCliente;
            this.QuantidadeCompras = quantidadeCompras;
            this.ValorComprado = valorComprado;
        }

        public int QuantidadeCompras { get; set; }

        public string NomeCliente { get; set; }

        public double ValorComprado { get; set; }

    }
}
