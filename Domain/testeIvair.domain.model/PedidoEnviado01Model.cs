using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace audatex.br.axpedidosend.domain.model
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

    }

    public class CHAMADA
    {

        public List<ENTRADA> ENTRADA { get; set; }
    }


    public class DESTINATARIO
    {

        public string CNPJ { get; set; }
        public string CPF { get; set; }

    }

    public class TELEFONES 
    {

        public string DDD1 { get; set; }
        public string NUMERO1 { get; set; }
        public string RAMAL1 { get; set; }
        public string DDD2 { get; set; }
        public string NUMERO2 { get; set; }
        public string RAMAL2 { get; set; }

    }

    public class FAX 
    {

        
        public string DDD { get; set; }
        public string NUMERO { get; set; }
        public string RAMAL { get; set; }

    }

    public class OFICINA 
    {

        public string PESSOA { get; set; }
        public string CGC { get; set; }
        public string CPF { get; set; }
        public string APELIDO { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public TELEFONES TELEFONES { get; set; }

        public FAX FAX { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public string CONTATO { get; set; }
        public string REFERENCIA { get; set; }

    }


    public class OFICINAS 
    {

         public List<OFICINA> OFICINA { get; set; }

    }


    public class FORNECEDOR
    {

        public string CNPJ { get; set; }           
        public string CODIGO { get; set; }        
        public string TIPO { get; set; }        
        public string APELIDO { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }

        public TELEFONES TELEFONES { get; set; }

        public FAX FAX { get; set; }
        public string IE { get; set; }               
        public string IM { get; set; }        
        public string CONTATO { get; set; }
        public string EMAIL { get; set; }

    }


    public class FORNECEDORES
    {

         public List<FORNECEDOR> FORNECEDOR { get; set; }

    }

    public class ORCAMENTO 
    {

        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string VERSAO { get; set; }
        public string CONCLUSAO { get; set; }
        public string SINISTRO { get; set; }
        public string APOLICE { get; set; }
        public string DATAVISTORIA { get; set; }

    }

       public class CGCS {

        public string OFICINA { get; set; }
        public string SEGURADORA { get; set; }
        public string SUCURSAL { get; set; }        
        public string REGULADORA { get; set; }
        public string MEDIADORA { get; set; }

    }

    

    public class CLIENTE {

        public string NOME { get; set; }
        public string TIPO { get; set; }        
        public string CGC { get; set; }
        public string CPF { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public TELEFONES TELEFONES { get; set; }

    }

        public class VEICULO {

        public string PLACA { get; set; }
        public string DESCRICAO { get; set; }
        public string COR { get; set; }
        public string KM { get; set; }
        public string OBS_VEIC { get; set; }
        public string COD_FUN { get; set; }
        public string COD_MEC { get; set; }
        public string COD_FMC { get; set; }
        public string ANOMODELO { get; set; }

    }

      public class ITEMPEDIDO {

        public string CODIGOPEDIDO { get; set; }
        public string CODIGO { get; set; }
        public string CODIGOCORR { get; set; }
        public string COD_PAI { get; set; }
        public string DESCRICAO { get; set; }
        public string QTDE { get; set; }
        public string PRECO_CON { get; set; }        
        public string PRECO_ALT { get; set; }
        public string CNPJ { get; set; }
        public string FLAG_PRECO { get; set; }
        public string NUM_SEQ { get; set; }                 
        public string STATUSITEMPEDIDO { get; set; }
        public string DT_PREVISAO { get; set; }
        public string DT_ENTREGA { get; set; }
        public string DT_FATURAMENTO { get; set; }
        public string CODTIPOPECA { get; set; }

    }

    public class ITENSPEDIDO {

          public List<ITEMPEDIDO> ITEMPEDIDO { get; set; }

    }

    
    public class PEDIDO {

        public string IDPEDIDO { get; set; }
        public string NUMERO { get; set; }
        public string DATAABERTURA { get; set; }

        public ORCAMENTO ORCAMENTO { get; set; }

        public CGCS CGCS { get; set; }
        public CLIENTE CLIENTE { get; set; }
        public VEICULO VEICULO { get; set; }
        public ITENSPEDIDO ITENSPEDIDO { get; set; }

    }


    public class PEDIDOS {

         public List<PEDIDO>  PEDIDO { get; set; }

    }

   
    public class PPECENVIADO01 {

        public CHAMADA CHAMADA { get; set; }
        public DESTINATARIO DESTINATARIO { get; set; }
        public OFICINAS OFICINAS { get; set; }
        public FORNECEDORES FORNECEDORES { get; set; }
        public PEDIDOS PEDIDOS { get; set; }
          
    }
}