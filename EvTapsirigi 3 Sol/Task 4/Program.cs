using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati*/
            int a = 12345;
            int b;
            int c;
            int qaliq;
            bool dogru= (a>=10000 && a<100000);

            if (dogru == false)
            {
                Console.WriteLine("Verilen eded 5 reqemli deyil");
                return;
            }
            qaliq = 12345 % 10000;
            b = (a - qaliq) / 10000;
            a = a % 10;
            c = (a + b) * (a + b);
            Console.WriteLine(c);
            



        }
    }
}
