using System.Collections.Generic;
using GerenciamentoDeClientes.Dominio;

namespace GerenciamentoDeClientes.Dados.Contratos
{
    public interface IRepositorioVenda
    {
        void ApagaVenda(int codigo);
        Venda BuscaPorCodigo(int cod);
        IEnumerable<Venda> BuscaTodas();
        Venda BuscaVendaPorCodigo(int codigo);
        IEnumerable<Venda> BuscaVendasComFiltro(FiltroTelaVendas venda);
        IEnumerable<Venda> BuscaVendasPorCliente(int codigoCliente);
        bool Cria(Venda venda);
    }
}