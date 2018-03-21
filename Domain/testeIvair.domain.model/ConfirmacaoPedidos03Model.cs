using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace audatex.br.axpedidosend.domain.model
{
    public class ConfirmacaoPedidos03Model

    {

        public class ENTRADA
        {

            public string CNPJ { get; set; }
            public string CHAMADOR { get; set; }
            public string PERFIL { get; set; }
            public string SENHA { get; set; }
            public string SERIE { get; set; }
            public string HD { get; set; }
            public string CPF { get; set; }
            public string PERITO { get; set; }
            public string IDPEDIDO { get; set; }

        }

        public class CHAMADA
        {

            public List<ENTRADA> ENTRADA { get; set; }
        }

        public class PEDIDO
        {

            public string IDPEDIDO { get; set; }
            public string NUMERO { get; set; }
           
        }


        public class PEDIDOS
        {

            public PEDIDO PEDIDO { get; set; }

        }

        public class CONFPEDIDOS03
        {

            public CHAMADA CHAMADA { get; set; }
            public PEDIDOS PEDIDO { get; set; }


        }

    }
}
