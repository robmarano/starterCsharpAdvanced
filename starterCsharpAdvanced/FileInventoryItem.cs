using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starterCsharpAdvanced
{
    public abstract class FileInventoryItem
    {
        public string Name { get; set; }
        public List<string> Extension;
        public int Count { get; set; }

        public FileInventoryItem(string name, List<string> exts)
        {
            Name = name;
            Extension = exts;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().ToString());
            sb.Append(": Name = ");
            sb.Append(Name);
            sb.Append("; Extension = ");
            foreach (string ext in Extension)
            {
                sb.Append(ext);
                sb.Append(" ");
            }
            sb.Append("; Count = ");
            sb.Append(Count);

            return (sb.ToString());
        }
    }
}
