using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject.Demo6
{
    public static  class TypeExtensions
    {
        public static TypeDesc GetDescp(this Type typeDesc)
        {
            return new TypeDesc
            {
                FullName = typeDesc.FullName,
                AssemblyName = typeDesc.AssemblyQualifiedName
            };
        }

    }

    public class TypeDesc
    {

        public string  FullName { get; set; }
        public string AssemblyName { get; set; }

    }
}
