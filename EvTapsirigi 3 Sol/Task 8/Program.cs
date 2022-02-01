using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8) Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap*/

            int a = 12345;
            int qaliq2;
            int qaliq;
            int netice;
            bool dogru = a >= 10000 && a < 100000;

            if (dogru == false)
            {
                Console.WriteLine("verilen 5 reqemli deyil");
                return;
            }
            qaliq = a % 10;//5
            qaliq2 = (a / 100) % 10;
            netice = qaliq2 + qaliq;
            Console.WriteLine(netice);
            




        }   
    }
}
