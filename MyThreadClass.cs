using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int t1 = 0; t1 <= 5; t1++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + t1);
                Thread.Sleep(1500);
            }
        }
    }
}