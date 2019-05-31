using System;

namespace _01_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleSumIfEqual(1, 2));
            Console.WriteLine(TripleSumIfEqual(3, 2));
            Console.WriteLine(TripleSumIfEqual(2, 2));
            Console.ReadKey();
        }

        static int TripleSumIfEqual(int a, int b)
        {
            if (a == b)
            {
                return 3 * (a + b);
            }
            else
            {
                return a + b;
            }
        }
    }
}
