using Microsoft.VisualStudio.TestTools.UnitTesting;
using audatex.br.axpedidopublisher.infrastructure.persistence;

namespace audatex.br.axpedidopublisher.domain.repository.Tests
{
    [TestClass]
    public class PedidoStatusRepositoryTest
    {
        [TestMethod]
        public void GetPedidoStatusRepository_SUCESS()
        {

            var unitOfWork = new UnitOfWork();
            var pedidoStatusRepository = new PedidoStatusRepository(unitOfWork);

            var lstPedido = pedidoStatusRepository.GetConfirmacaoPedidoEnviado();             
                
            Assert.IsNotNull(lstPedido);
        }
        [TestMethod]
        public void GetPedidoEnviadosRepository_SUCESS()
        {

            var unitOfWork = new UnitOfWork();
            var pedidoStatusRepository = new PedidoStatusRepository(unitOfWork);

            var lstPedido = pedidoStatusRepository.GetPedidosEnviados();

            Assert.IsNotNull(lstPedido);
        }        
    }
}


