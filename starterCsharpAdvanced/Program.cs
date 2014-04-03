using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        bool done;

        static void Main()
        {
            Program tt = new Program();   // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();
        }

        // Note that Go is now an instance method
        void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
