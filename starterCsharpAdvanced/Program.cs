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
            t.Join();
            Console.WriteLine("Thread t has ended.");
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
