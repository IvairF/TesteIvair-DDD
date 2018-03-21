using System;
using System.Collections.Generic;

using testeIvair.domain;
using testeIvair.domain.model;
using testeIvair.domain.repository;
using testeIvair.infrastructure.persistence;
using testeIvair.infrastructure.log;
using System.Net;
using System.Web.Http;


namespace testeIvair.application
{
    public class PedidoFacade
    {
        private static IUnitOfWork _unitOfWork;           
        private static dynamic _repositoryPedido;
      

        public PedidoFacade()
        {
             
                _unitOfWork = new UnitOfWork();               

                _repositoryPedido = RepositoryFactory.CreateRepository<PedidoModel, PedidoRepository>(_unitOfWork);
               
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public List<PedidoModel> GetPedidoPendente()
        {
                List<PedidoModel> lstPedidoPendente = _repositoryPedido.GetPedidos();

                Log.RecordInfo(string.Empty);

                return lstPedidoPendente;                       
        }
       
    }
}