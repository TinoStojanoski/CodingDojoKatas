using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojoKatas
{
    internal class FizzBuzz
    {

        public static void AusgebenZahlen()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuz");
                        continue;
                    }
                    Console.WriteLine("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
