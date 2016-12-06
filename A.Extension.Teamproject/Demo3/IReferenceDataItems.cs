using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject.Demo3
{
    public interface IReferenceDataItems
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}
