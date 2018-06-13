using System.Collections.Generic;
using GerenciamentoDeClientes.Dominio;

namespace GerenciamentoDeClientes.Dados.Contratos
{
    public interface IRepositorioCliente
    {
        void ApagaCliente(int codigo);
        Cliente BuscaPorCodigo(int cod);
        IEnumerable<Cliente> BuscaPorNome(string nome);
        IEnumerable<Cliente> BuscaTodos();
        void Cria(Cliente cliente);
    }
}