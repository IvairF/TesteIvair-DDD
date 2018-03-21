using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Newtonsoft.Json;
using System.Xml;

namespace testeIvair.infrastructure.common
{
    public class Converter
    {

      
        public static string ObjToJson(dynamic obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    
    }
}
