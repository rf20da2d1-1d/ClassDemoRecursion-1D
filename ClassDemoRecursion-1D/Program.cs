using System;

namespace ClassDemoRecursion_1D
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursionWorker worker = new RecursionWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
