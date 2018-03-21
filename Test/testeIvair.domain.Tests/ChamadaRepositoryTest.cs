using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using audatex.br.axpedidopublisher.domain;
using audatex.br.axpedidopublisher.infrastructure.persistence;


namespace audatex.br.axpedidopublisher.domain.repository.Tests
{
    [TestClass]
    public class ChamadaRepositoryTest
    {
       
        [TestMethod]
        public void GetRegWindows_SUCESS()
        {

            var lchamada = new DadosCliente().GetChamada();

            Assert.IsNotNull(lchamada);
        }
    }
}
