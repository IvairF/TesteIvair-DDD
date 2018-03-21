using Microsoft.VisualStudio.TestTools.UnitTesting;

using audatex.br.axpedidopublisher.domain.repository;
using audatex.br.axpedidopublisher.infrastructure.persistence;

namespace audatex.br.axpedidopublisher.domain.repository.Tests
{
    [TestClass]
    public class PedidoRepositoryTest
    {
        [TestMethod]
        public void GetPedidoPendentePedidoRepository_SUCESS()
        {
            var unitOfWork = new UnitOfWork();
            var pedidoRepository = new PedidoRepository(unitOfWork);

            var lstPedido = pedidoRepository.GetPedidosPendente();
            Assert.IsNotNull(lstPedido);
        }
    }
}