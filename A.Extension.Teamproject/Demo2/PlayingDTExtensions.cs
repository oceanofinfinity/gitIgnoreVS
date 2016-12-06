using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System
{
    public static class PlayingDTExtensions
    {
        public static string ToXMLDate(this DateTime xmldate)
        {
            return XmlConvert.ToString(xmldate,XmlDateTimeSerializationMode.Utc);
        }

    }
}
