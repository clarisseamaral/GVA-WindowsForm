using GerenciamentoDeClientes.Dados;
using GerenciamentoDeClientes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClientes.Negocio
{
    public class CadastroCliente
    {
        private readonly RepositorioCliente _repositorioCliente;
        private readonly RepositorioVenda _repositorioVenda;

        public CadastroCliente(): this(new RepositorioCliente(), new RepositorioVenda())
        {
        }

        public CadastroCliente(RepositorioCliente repositorioCliente, RepositorioVenda repositorioVenda)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioVenda = repositorioVenda;
        }

        public void CadastraCliente(Cliente cliente)
        {
            _repositorioCliente.Cria(cliente);
        }

        public IEnumerable<Cliente> BuscaClientePorNome(string nome)
        {
            return _repositorioCliente.BuscaPorNome(nome);
        }

        public IEnumerable<Cliente> BuscaTodosClientes()
        {
            return _repositorioCliente.BuscaTodos();
        }

        public bool ApagaCliente(int codigo)
        {
            var lvendas = _repositorioVenda.BuscaVendasPorCliente(codigo);

            if (lvendas.Count() > 0)
                return false;

            _repositorioCliente.ApagaCliente(codigo);
            return true;
        }

        public Cliente BuscaClientePorCodigo(int codigo)
        {
            return _repositorioCliente.BuscaPorCodigo(codigo);
        }

        public void AtualizaCliente (Cliente cliente)
        {
            _repositorioCliente.ApagaCliente(cliente.Codigo);
            _repositorioCliente.Cria(cliente);
        }
    }
}
