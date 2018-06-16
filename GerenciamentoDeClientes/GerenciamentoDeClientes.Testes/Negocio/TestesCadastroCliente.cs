using System;
using GerenciamentoDeClientes.Dados.Contratos;
using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using Moq;
using NUnit.Framework;

namespace GerenciamentoDeClientes.Testes.Negocio
{
    [TestFixture]
    public class TestesCadastroCliente
    {
        [Test]
        public void ApagaClienteSemVenda()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();

            var cadastroCliente = new CadastroCliente(mockCliente.Object, mockVendas.Object);
            var retorno = cadastroCliente.ApagaCliente(1);
            
            Assert.IsTrue(retorno);
            mockCliente.Verify(r => r.ApagaCliente(1));
        }

        [Test]
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

        [Test]
        public void CadastraClienteSemCamposObrigatorios()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();

            var cadastroCliente = new CadastroCliente(mockCliente.Object, mockVendas.Object);

            var retorno = cadastroCliente.CadastraCliente(new Cliente() {  } );

            Assert.IsFalse(retorno);
        }

    }
}
