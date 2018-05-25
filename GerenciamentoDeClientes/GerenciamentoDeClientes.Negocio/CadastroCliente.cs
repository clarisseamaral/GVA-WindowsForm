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
        public static void CadastraCliente(Cliente cliente)
        {
            new RepositorioCliente().Cria(cliente);
        }

        public static IEnumerable<Cliente> BuscaClientePorNome(string nome)
        {
            return new RepositorioCliente().BuscaPorNome(nome);
        }

        public static IEnumerable<Cliente> BuscaTodosClientes()
        {
            return new RepositorioCliente().BuscaTodos();
        }

        public static bool ApagaCliente(int codigo)
        {
            var lvendas = new RepositorioVenda().BuscaVendasPorCliente(codigo);

            if (lvendas.Count() > 0)
                return false;

            new RepositorioCliente().ApagaCliente(codigo);
            return true;
        }

        public static Cliente BuscaClientePorCodigo(int codigo)
        {
            return new RepositorioCliente().BuscaPorCodigo(codigo);
        }

        public static void AtualizaCliente (Cliente cliente)
        {
            new RepositorioCliente().ApagaCliente(cliente.Codigo);
            new RepositorioCliente().Cria(cliente);
        }
    }
}
