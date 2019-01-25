using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            List<int> firstlist = new List<int>();
            firstlist.Add(2);           
            bool isprime = true;
            for (int i = 3; i < 100000; i+=2)
            {
                isprime = true;
                
                for (int j = 3; j <= i-1; j++)
                {

                    if (i%j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime == true) firstlist.Add(i);

            }
            watch.Stop();
                       
            var elapsedMs = watch.ElapsedMilliseconds;

            foreach (int i in firstlist )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("how many?:"+firstlist.Count);
                    
            Console.WriteLine("Time taken is "+ (elapsedMs/1000f) +" seconds");

            Console.ReadLine();

        }

    }
}
