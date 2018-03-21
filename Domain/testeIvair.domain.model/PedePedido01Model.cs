using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace audatex.br.axpedidosend.domain.model
{
    public class PedePedido01Model
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
            public string QTDE { get; set; }

        }

        public class CHAMADA
        {

            public List<ENTRADA> ENTRADA { get; set; }
        }

        public class PEDEPEDIDOS01

        {

            public CHAMADA CHAMADA { get; set; }
         

        }
    }
}
