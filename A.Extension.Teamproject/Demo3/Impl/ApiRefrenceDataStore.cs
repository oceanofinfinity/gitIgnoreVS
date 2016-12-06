using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject.Demo3.Impl
{
    public abstract class ApiDataSource
    {
        public string name = "API";
    }

    public class ApiRefrenceDataStore : ApiDataSource, IReferenceDataItems
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem {Code="C#",Description="C sharp library from API" },
                new ReferenceDataItem { Code="VB ",Description="VB library from API"}
        };
        }
    }
}
