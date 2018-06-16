using System;
using GerenciamentoDeClientes.Dados.Contratos;
using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace GerenciamentoDeClientes.Testes.Negocio
{
    [TestFixture]
    public class TesteCadastroVenda
    {
        [Test]
        public void CadastraVendaVencida()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();

            var retorno = mockVendas.Object.Cria(new Venda()
            {
                Cliente = null,
                DataVencimento = new DateTime(2018, 05, 04),
                DataVenda = DateTime.Now,
                Descricao = "Venda teste",
                ValorTotal = 45.50
            });

            Assert.IsFalse(retorno);
        }

        [Test]
        public void CadastraVendaComPagamentoAnteriorVenda()
        {
            var mockCliente = new Mock<IRepositorioCliente>();
            var mockVendas = new Mock<IRepositorioVenda>();

            var retorno = mockVendas.Object.Cria(new Venda()
            {
                Cliente = null,
                DataVencimento = new DateTime(2018, 07, 04),
                DataVenda = DateTime.Now,
                DataPagamento = DateTime.Now.AddDays(-2),
                Descricao = "Venda teste",
                ValorTotal = 45.50
            });

            Assert.IsFalse(retorno);
        }
    }
}
