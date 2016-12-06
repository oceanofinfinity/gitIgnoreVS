using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject.Demo3.Impl
{
    public abstract class SQLReference
    {
        public  string Name = "SQL";
    }

    public class SQLReferenceDataSource : SQLReference, IReferenceDataItems
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code="C#", Description="from SQL"},
                new ReferenceDataItem {Code="VB" , Description="from Sql"}
            };

        }
    }
}
