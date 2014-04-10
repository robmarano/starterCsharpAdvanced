using System;
using System.Threading;

namespace starterCsharpAdvanced
{
    class Program
    {
        public static int t1Val { get; set; }
        static readonly object locker1 = new object();
        public static int t2Val { get; set; }
        static readonly object locker2 = new object();

        static void Main()
        {
            Thread.CurrentThread.Name = "main";
            t1Val = 1;
            Thread t1 = new Thread(() => Go());
            t1.Name = "thread1";
            t2Val = 2;
            Thread t2 = new Thread(() => Go());
            t2.Name = "thread2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        static void Go()
        {
            int temp;
            for (int y = 0; y < 10000; y++)
            {
                lock (locker1)
                {
                    temp = t1Val;
                    lock (locker2)
                    {
                        t1Val = t2Val;
                        t2Val = temp;
                    }
                }
                int valu = 0;
                if (Thread.CurrentThread.Name == "thread1")
                {
                    valu = t1Val;
                }
                else if (Thread.CurrentThread.Name == "thread2")
                {
                    valu = t2Val;
                }
                //Console.Write(Thread.CurrentThread.Name + ":" + valu);
                Console.Write(valu);
            }
            Console.WriteLine("");
        }
    }
}
