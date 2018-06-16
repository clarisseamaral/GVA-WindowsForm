using GerenciamentoDeClientes.Dados;
using GerenciamentoDeClientes.Dados.Contratos;
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
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioVenda _repositorioVenda;

        public CadastroVenda(): this(new RepositorioCliente(), new RepositorioVenda())
        {
        }

        public CadastroVenda(IRepositorioCliente repositorioCliente, IRepositorioVenda repositorioVenda)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioVenda = repositorioVenda;
        }

        public void CadastraVenda(Venda venda)
        {
            _repositorioVenda.Cria(venda);
        }

        public IEnumerable<Venda> BuscaVendasComFiltro(FiltroTelaVendas filtro)
        {
            return _repositorioVenda.BuscaVendasComFiltro(filtro);
        }

        public IEnumerable<Venda> BuscaTodasVendas()
        {
            return _repositorioVenda.BuscaTodas();
        }

        public void ApagaVenda(int codigo)
        {
            _repositorioVenda.ApagaVenda(codigo);
        }

        public Venda BuscaVendaPorCodigo(int codigo)
        {
            return _repositorioVenda.BuscaVendaPorCodigo(codigo);
        }

        public void AtualizaVenda(Venda venda)
        {
            _repositorioVenda.ApagaVenda(venda.Codigo);
            _repositorioVenda.Cria(venda);
        }
    }
}
