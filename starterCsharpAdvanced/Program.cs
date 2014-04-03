using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(() => Print("Hello from t!"));
            Print("From Main thread");
            t.Start();
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
