using Microsoft.VisualStudio.TestTools.UnitTesting;

using audatex.br.axpedidopublisher.domain.repository;
using audatex.br.axpedidopublisher.infrastructure.persistence;

namespace audatex.br.axpedidopublisher.domain.repository.Tests
{
    [TestClass]
    public class UsuarioRepositoryTest
    {
        [TestMethod]
        public void Getperito_SUCESS()
        {
            var unitOfWork = new UnitOfWork();
            var UsuarioRepository = new UsuarioRepository(unitOfWork);

            var lstPerito = UsuarioRepository.GetPerito("11111111111");
            Assert.IsNotNull(lstPerito);
        }
    }
}