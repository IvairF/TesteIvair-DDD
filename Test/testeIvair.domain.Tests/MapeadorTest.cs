using audatex.br.axpedidopublisher.infrastructure.persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using audatex.br.axpedidopublisher.domain.Map;

namespace audatex.br.axpedidopublisher.domain.Tests
{
    [TestClass]
    public class MapeadorTest
    {
        [TestMethod]
        public void MapeadorChamada_SUCESS()
        {
            var chamada = new DadosCliente().GetChamada();
            var MapeadorChamada = new MapeadorChamada().CriarChamada(chamada);

            Assert.IsNotNull(MapeadorChamada);
        }
        [TestMethod]
        public void MapeadorDestinatario_SUCESS()
        {
            var chamada = new DadosCliente().GetChamada();
            var MapeadorChamada = new MapeadorDestinatario().CriarDestinatario(chamada);

            Assert.IsNotNull(MapeadorChamada);
        }       
    }
}
