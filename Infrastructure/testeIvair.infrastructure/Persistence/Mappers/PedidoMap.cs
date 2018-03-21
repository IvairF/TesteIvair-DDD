using System.Data.Entity.ModelConfiguration; 
using testeIvair.domain.model;

namespace testeIvair.infrastructure.persistence.mappers
{
    public class PedidoMap : EntityTypeConfiguration<PedidoModel>
    {
        public PedidoMap()
        {
            ToTable("Pedido");
            HasKey(x => x.Pedido);
            
        }
    }
}