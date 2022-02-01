using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int qaliq;
            bool Dogru = 100000000 <= a && a < 1000000000;
            if (Dogru == false)
            {
                Console.WriteLine("Verilen 9 reqemli deyil!");
                return;
            }
            int qaliq2;
            int netice=0;
            qaliq = a % 1000;              //789
            a = (a - qaliq) / 1000;       //(123456789-789)/1000=123456
            a=a % 1000;                  //456


            while (a > 0)
            {
            qaliq2 = a % 10;           //6<----
            a = (a - qaliq2) / 10;    //45
            netice = netice + qaliq2;
                Console.WriteLine(netice); 
            }
            
            




        }
    }
}
