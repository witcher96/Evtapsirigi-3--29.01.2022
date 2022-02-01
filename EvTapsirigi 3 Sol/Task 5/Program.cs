using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.*/

            int a = 123456;
            int b;
            int qaliq;
            bool dogru = a >= 100000 && a < 1000000;
            if (dogru == false)
            {
                Console.WriteLine("Verilen eded 6 reqemli deyil");
                return;
            }
            qaliq = a % 100000;
            b = (a - qaliq)/100000;//1
            qaliq = qaliq * 10 + b;
            Console.WriteLine(qaliq);
        }
    }
}
