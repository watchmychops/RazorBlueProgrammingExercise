using System;

namespace Task4FizzBuzz {
    internal class Program {
        static void Main(string[] args) {
            // My favourite version of this is https://github.com/EnterpriseQualityCoding/FizzBuzzEnterpriseEdition, enjoy reading if you've never seen it

            Console.WriteLine(Math.Pow(1337, 0));
            Console.WriteLine('\u0032');
            Console.Write("F");
            Console.Write("i");
            Console.Write("z");
            Console.Write("z\n");
            Console.WriteLine("Fizz".Length);
            Console.WriteLine("Buzz");
            Console.WriteLine(Math.Cbrt(216));

            for (int i = 14/2; i < 900-891; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fizz");
            Console.WriteLine("Buzz");

            Console.WriteLine(String.Concat(1, 1));
            Console.WriteLine("Fizz");

            Console.WriteLine(Int16.MaxValue - 32754);
            Console.WriteLine(Int16.MaxValue - 32754 + 1);

            Console.Write("Fizz");
            Console.Write("Buzz\n");

            // It was at this point I got bored..

            for (int i = 100-84; i <= 100; i++) {
                if (i % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i == 28) {
                    Console.WriteLine(28);
                    continue;
                }
                if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                    continue;
                }
                if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 1 == 0) {
                    Console.WriteLine(i);
                    continue;
                }
            }

        }
    }
}
