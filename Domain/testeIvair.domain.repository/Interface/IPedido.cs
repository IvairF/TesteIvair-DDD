using System;
using System.Collections.Generic;
using System.Linq;

namespace testeIvair.domain.repository.interfaces
{
    public interface IPedido<T> : IRepository<T>
    {
        IEnumerable<T> GetPedidoPendente(); 
    }
}
