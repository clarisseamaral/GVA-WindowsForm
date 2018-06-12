using System;
using GerenciamentoDeClientes.Dados.Contratos;
using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GerenciamentoDeClientes.Testes.Negocio
{
    [TestClass]
    public class TestesCadastroCliente
    {
        [TestMethod]
        public void ApagaClienteSemVenda()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();

            var cadastroCliente = new CadastroCliente(mockCliente.Object, mockVendas.Object);
            var retorno = cadastroCliente.ApagaCliente(1);

            Assert.IsTrue(retorno);
            mockCliente.Verify(r => r.ApagaCliente(1));
        }

        [TestMethod]
        public void ApagaClienteComVenda()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();
            mockVendas.Setup(r => r.BuscaVendasPorCliente(1)).Returns((int codigo) => new[] { new Venda() });

            var cadastroCliente = new CadastroCliente(mockCliente.Object, mockVendas.Object);
            var retorno = cadastroCliente.ApagaCliente(1);

            Assert.IsFalse(retorno);
            mockCliente.VerifyNoOtherCalls();
        }
    }
}
