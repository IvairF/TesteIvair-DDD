using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using testeIvair.domain.model;

using testeIvair.infrastructure.persistence;




using System;


namespace testeIvair.domain.repository
{
    public class PedidoRepository : Repository<PedidoModel>
    {
        private readonly IUnitOfWork _db;

        public PedidoRepository(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        public IEnumerable<PedidoModel> GetPedidos()
        {
            IEnumerable<PedidoModel> lista = new List<PedidoModel>();

            var lstPedidos = (_db.Pedidos).ToList();      


            return lstPedidos;

        }
    }
}
         
   