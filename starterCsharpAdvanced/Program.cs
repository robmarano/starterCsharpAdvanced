using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        public static void Main()
        {
            new Thread(Go).Start();
        }

        static void Go()
        {
            try
            {
                // ...
                throw null;    // The NullReferenceException will get caught below
                // ...
            }
            catch (Exception ex)
            {
                // Typically log the exception, and/or signal another thread
                // that we've come unstuck
                // ...
            }
        }
    }
}
