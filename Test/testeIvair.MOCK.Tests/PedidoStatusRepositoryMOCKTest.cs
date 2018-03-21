using System;
using System.Collections.Generic;
using System.Data.Entity;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using audatex.br.axpedidopublisher.domain.model;
using audatex.br.axpedidopublisher.domain.repository;
using audatex.br.axpedidopublisher.infrastructure.persistence;

namespace audatex.br.axpedidopublisher.domain.repository.MOCK.Tests
{
    [TestClass]
    public class PedidoStatusRepositoryMOCKTest
    {
        [TestCategory("MOCK"), TestMethod]
        public void AddPedidoStatusRepositoryMOCK_SUCESS()
        {
                    
            

            var mockSet = new Mock<IDbSet<PedidoStatusModel>>();
            var mockContext = new Mock<UnitOfWork>();
            
            var pedidoStatusDomain = new PedidoStatusModel();

            mockContext.Setup(m => m.PedidoStatus).Returns(mockSet.Object);

            var repository = new PedidoStatusRepository(mockContext.Object);
            repository.Add(pedidoStatusDomain);

            mockSet.Verify(m => m.Add(It.IsAny<PedidoStatusModel>()), Times.Once());            
        }
    }
}
