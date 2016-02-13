using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1
{

    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        private static void F2()
        {
            Thread t2 = new Thread(new ParameterizedThreadStart(doit2));
            t2.Start();
            string line = Console.ReadLine();
            t2.Abort();
        }

         static void doit2(object obj)
        {
            while (true)
            {
                Console.WriteLine("wait...");
                Thread.Sleep(1000);
            }
        }

        private static void F1()
        {
            Timer t = new Timer(new TimerCallback(doit));
            t.Change(0, 1000);

            bool ok = false;

            while (!ok)
            {
                string line = Console.ReadLine();
                ok = true;
            }

        }

        private static void doit(object state)
        {
            Console.WriteLine("wait...");
        }
    }
}
