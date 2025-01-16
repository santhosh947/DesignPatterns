using System;
using System.Diagnostics;

namespace DesignPatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SingletonExecutor.ThreadSafeTests();
            SingletonExecutor.BasicTests();
            stopwatch.Stop();
            Console.WriteLine($" Singleton Tests Execution Time: {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}