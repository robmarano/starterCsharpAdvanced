using System;
using System.IO;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argument["+i+"] = "+args[i]);
                try
                {
                    string text = System.IO.File.ReadAllText(args[i]);
                    Console.WriteLine(text);
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.ToString());n
                }
            }

        }
    }
}
