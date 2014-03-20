using System;
using System.IO;
using System.Security;

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
                    // see http://msdn.microsoft.com/en-us/library/ms143368(v=vs.110).aspx
                    string text = File.ReadAllText(args[i]);
                    Console.WriteLine(text);
                }
                // The following exceptions are possibly thrown by File.ReadAllText()
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (SecurityException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                }
            }

        }
    }
}
