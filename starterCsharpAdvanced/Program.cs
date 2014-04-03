using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(Go);    // No need to explicitly use ThreadStart

            t.Start();   // Run Go() on the new thread.
            Go();        // Simultaneously run Go() in the main thread.
        }

        static void Go()
        {
            Console.WriteLine("hello!");
        }
    }
}
