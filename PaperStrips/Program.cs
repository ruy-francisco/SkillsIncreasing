using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperStrips
{
    public class Program
    {
        public static int MinPieces(int[] original, int[] desired)
        {
            int minPieces = 1;

            var dictOriginal = original.Select((value, key) => new { value, key })
                .ToDictionary(pair => pair.key, pair => pair.value);

            for(int i = 0; i < original.Length - 1; i++)
            {
                int sumOfKeys = dictOriginal.First(d => d.Value == desired[i + 1]).Key - dictOriginal.First(d => d.Value == desired[i]).Key;
                if(sumOfKeys != 1)
                    minPieces++;
            }

            return minPieces;
        }

        static void Main(string[] args)
        {
            int[] original = new int[] { 1, 4, 3, 2 };
            int[] desired = new int[] { 1, 2, 4, 3 };
            Console.WriteLine(MinPieces(original, desired));
            Console.ReadKey();
        }
    }
}
