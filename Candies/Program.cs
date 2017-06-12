using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        public static int CountCandies(int startingAmount, int newEvery)
        {
            int EatenCandies = 0;

            while(startingAmount >= newEvery)
            {
                EatenCandies += newEvery;
                startingAmount -= newEvery;
                startingAmount++;
            }

            EatenCandies += startingAmount;

            return EatenCandies;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CountCandies(5, 2));
            Console.ReadKey();
        }
    }
}
