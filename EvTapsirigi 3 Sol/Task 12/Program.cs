using System;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.*/

            int a = 12345;
            int qaliq;
            int netice = 0;
            int netice2 = 0;
            int b = 54321;
            int qaliq2;
            int c;
            bool isSucces = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;
            if (isSucces == false)
            {
                Console.WriteLine("Verilen 5 reqemli deyil");
                return;
            }
            while (a > 0 && b>0)
            {
                qaliq = a % 10;
                qaliq2=b % 10;
                a =(a - qaliq) / 10;
                b= (b - qaliq2) / 10;    
                netice = netice + qaliq;
                netice2 = netice * netice;
            }

            c = netice + netice2;
            c = c * 10 + 5;
            Console.WriteLine(c);
        }
    }
}
