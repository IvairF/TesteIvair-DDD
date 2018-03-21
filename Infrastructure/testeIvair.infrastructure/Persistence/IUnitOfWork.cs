using System.Data.Entity;

using testeIvair.domain.model;

namespace testeIvair.infrastructure.persistence
{
    public interface IUnitOfWork
    {
        IDbSet<PedidoModel> Pedidos { get; set; }
        void Commit();
    }
}
