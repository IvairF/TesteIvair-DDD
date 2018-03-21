using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testeIvair.infrastructure.Common
{
    public class TratarCaracteres
    {
        public static string RemoverCaracteresEspeciais(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return String.Empty;

            byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(texto);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
