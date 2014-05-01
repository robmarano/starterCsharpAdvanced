using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> excelExtentions = new List<string>();
            excelExtentions.Add("xls");
            excelExtentions.Add("xlsx");
            FileInventoryItem excelItem = new ExcelFileInventoryItem("Excel", excelExtentions);
            Console.WriteLine(excelItem);


        }
    }
}
