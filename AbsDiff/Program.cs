using System;

namespace AbsDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gogo(45));
            Console.WriteLine(Gogo(30));
            Console.WriteLine(Gogo(51));
            Console.ReadKey();

        }

        static int Gogo(int n)
        {
            return (n > 51) ? (n - 51) * 3 : Math.Abs(n - 51);
        }
    }
}
