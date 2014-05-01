using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starterCsharpAdvanced
{
    public class ExcelFileInventoryItem : FileInventoryItem
    {
        public ExcelFileInventoryItem(string name, List<string> exts) : base(name, exts)
        {
        }
    }
}
