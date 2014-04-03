using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        static bool done;    // Static fields are shared between all threads

        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
