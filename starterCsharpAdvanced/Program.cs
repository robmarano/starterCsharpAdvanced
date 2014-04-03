using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(Go);
            t.Start();
            Go();
            Console.WriteLine("Main() thread has ended.");
            t.Join();
            Console.WriteLine("Thread t has ended.");
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
            Console.WriteLine("\n...zzz...");
            Thread.Sleep(1500); // sleep for 1500 milliseconds
        }
    }
}
