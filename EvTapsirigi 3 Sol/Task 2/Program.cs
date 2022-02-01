using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3*/

            int a = 123456;
            int qaliq;
            int qaliq2;
            int netice = 0;
            bool Dogru= (a >= 100000 && a < 1000000);

            if (Dogru == false)
            {
                Console.WriteLine("verilen 6 reqemli deyil");
                return;
            }
                qaliq = a % 1000;  
                a = (a - qaliq) / 1000; 

            while (a > 0)
            {
                qaliq2 = a % 10;
                a = (a - qaliq2)/10;  
                netice = netice + qaliq2;
                Console.WriteLine(netice);
                

            }
         




        }   
    }
}
