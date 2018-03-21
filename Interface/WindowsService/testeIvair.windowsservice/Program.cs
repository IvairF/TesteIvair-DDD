using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace TesteIvair.windowsservice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
//#if (!DEBUG)

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new AxPedidoPublisher()
            };
            ServiceBase.Run(ServicesToRun);
//#else

//            AxPedidoPublisher AxPedidoPublisher = new AxPedidoPublisher();
//            // Chamada do seu método para Debug.
//            AxPedidoPublisher.Start();
//            // Coloque sempre um breakpoint para o ponto de parada do seu código.
//            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);


//#endif
        }
    }
}
