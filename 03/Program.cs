using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Haha(30,10));
            Console.WriteLine(Haha(20,10));
            Console.WriteLine(Haha(15,15));
            Console.WriteLine(Haha(10,34));
            Console.ReadKey();
        }

        static Boolean Haha(int a, int b)
        {
            // optimal:
            // return a == 30 || b == 30 || (a + b == 30);
            if (a==30 || b == 30 || a+b==30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
