using System;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9) 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
    sonra cut yerde dayanlarinda bir eded duzlet,
    sonra onlari topla*/

            int a = 123456789;//13579
            int b;
            int qaliq;
            int cem ;
            int netice1 = 0;
            int netice2 = 0;
            int counter = 1;
            bool issucces = a >= 100000000 && a < 1000000000;

            if (issucces == false)
            {
                Console.WriteLine("Verilen eded 9 reqemli deyil");
                return;
            }
            while (a > 0)
            {
                qaliq = (a % 10);//9
                a = (a - qaliq) / 10;

                if (counter % 2 != 0)
                {
                    netice1 = netice1 * 10 + qaliq;

                }

                if (counter % 2 == 0)
                {
                    netice2 = netice2 * 10 + qaliq;
                }
                counter++;

            }
           
            a = netice1;
            b = netice2;
            netice1 = 0;
            netice2 = 0;

            while ((a > 0)&&(b>0))
            {
               qaliq = a % 10;
               a = (a - qaliq) / 10;
               netice1 = netice1 * 10 + qaliq;
                
                 
            }
            while (b > 0)
            {
                qaliq = b % 10;
                b = (b - qaliq) / 10;
                netice2 = netice2 * 10 + qaliq;

            }
            cem = netice1 + netice2;
            Console.WriteLine(cem);
        }
    }
}
