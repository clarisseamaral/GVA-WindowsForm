using GerenciamentoDeClientes.Dados;
using GerenciamentoDeClientes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClientes.Negocio
{
    public class CadastroVenda
    {
        public static void CadastraVenda(Venda venda)
        {
            new RepositorioVenda().Cria(venda);
        }

        public static IEnumerable<Venda> BuscaVendasComFiltro(FiltroTelaVendas filtro)
        {
            return new RepositorioVenda().BuscaVendasComFiltro(filtro);
        }

        public static IEnumerable<Venda> BuscaTodasVendas()
        {
            return new RepositorioVenda().BuscaTodas();
        }

        public static void ApagaVenda(int codigo)
        {
            new RepositorioVenda().ApagaVenda(codigo);
        }

        public static Venda BuscaVendaPorCodigo(int codigo)
        {
            return new RepositorioVenda().BuscaVendaPorCodigo(codigo);
        }

        public static void AtualizaVenda(Venda venda)
        {
            new RepositorioVenda().ApagaVenda(venda.Codigo);
            new RepositorioVenda().Cria(venda);
        }

       
    }
}
