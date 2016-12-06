using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using A.Extension.Teamproject.Demo6;

namespace A.Extension.Teamproject.Demo5
{
    public static class ObjectExtension
    {
        
        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static string GetJsonTypeJsonString(this object obj)
        {
            var desc = obj.GetType().GetDescp();
            return desc.ToJsonString();
        }

    }
}
