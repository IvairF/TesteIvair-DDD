using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;

using testeIvair.application;
using testeIvair.infrastructure.log;


namespace TesteIvair.console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Log.RecordInfo("# INICIO DO PROCESSAMENTO");
                Log.RecordInfo("****************************************");
                Log.RecordInfo("****************************************");
                Log.RecordInfo(string.Empty);

                Log.RecordInfo("# INÍCIO - PEGANDO PEDIDOS");
                Log.RecordInfo(string.Empty);

                PedidoFacade pedidoFacade = new PedidoFacade();
                //pedidoFacade.GetPedidoPendente(exchange, queuePedido);

                Log.RecordInfo(string.Empty);
                Log.RecordInfo("# FIM - ENVIANDO PEDIDO");
            }
            catch (Exception ex)
            {
                Log.RecordInfo(string.Empty);
                Log.RecordError(ex);
            }
            finally
            {
                Log.RecordInfo(string.Empty);
                Log.RecordInfo("****************************************");
                Log.RecordInfo("****************************************");
                Log.RecordInfo("# FIM DO PROCESSAMENTO");
                Log.RecordInfo(string.Empty);
                Log.RecordInfo(string.Empty);

                Console.Read();
            }
        }
    }
}
