using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(Print);
            t.Start("Hello from t!");
            Print("Hello from the Main line thread.");
        }

        static void Print(object messageObj)
        {
            string message = (string)messageObj;   // We need to cast here
            Console.WriteLine(message);
        }
    }
}
