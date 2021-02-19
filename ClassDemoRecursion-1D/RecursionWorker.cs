using System;

namespace ClassDemoRecursion_1D
{
    public class RecursionWorker
    {
        public RecursionWorker()
        {
        }

        public void Start()
        {
            Console.WriteLine("========= NORMAL ==========");
            //NormalLoop(17);
            Console.WriteLine();

            Console.WriteLine("========= REKURSIV ==========");
            //Recursive(17);
            Console.WriteLine();

            Console.WriteLine("========= FIBUNACCI TAL ==========");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.WriteLine(Fibunacci(i));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingen fibunacci for " + i);
                }
            }
            
            Console.WriteLine();

        }


        private void NormalLoop(int i)
        {
            for (int j = i; j > 0 ; j--)
            {
                Console.WriteLine("loop : " + j);
            }

        }

        private void Recursive(int i)
        {
            /*
             * Tre betingelser
             *     1) STOP betingelse -- ellers kører uendeligt eller rettere til stackoverflow
             *     2) Lave noget
             *     3) Kalder sig selv (altså kald af egen metode) - MEN med et mindre problem
             */

            // Stop
            if (i == 0) return;
            
            // lave noget 
            Console.WriteLine("Rekursion " + i);

            // Kalde sig selv på et mindre problem
            Recursive(i-1);
        }

        private int Fibunacci(int i)
        {
            if (i <= 0) throw new ArgumentException();

            // Stop
            if (i == 1 || i == 2)
                return 1;

            // lave noget - ikke noget her
            return Fibunacci(i - 1) + Fibunacci(i - 2);

        }
    }
}