using System.Data.Entity;
using System.Configuration;

using testeIvair.domain.model;
using testeIvair.infrastructure.persistence;
using testeIvair.infrastructure.persistence.mappers;
using Devart.Data.Oracle.Entity.Configuration;


namespace testeIvair.infrastructure.persistence

{

       public class UnitOfWork : DbContext, IUnitOfWork
    {
                    
        public virtual IDbSet<PedidoModel> Pedidos { get; set; }        

        public UnitOfWork()
            : base("Contexto")
        {

            OracleEntityProviderConfig.Instance.CodeFirstOptions.TruncateLongDefaultNames = true;                     

            Configuration.LazyLoadingEnabled = false;
        }

        public void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PedidoMap());                      
        }
    }
}
