using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    public class program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Console.WriteLine("enter number:");
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);

        }
    }
}