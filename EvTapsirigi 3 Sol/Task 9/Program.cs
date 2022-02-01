using System;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439*/

            int a = 123456789;//13579
            int qaliq;
            int netice1=0;
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

                if(counter % 2 != 0)
                {
                    netice1 = netice1 * 10 + qaliq;

                }
                counter++;

            }
                

            a = netice1;
            netice1 = 0;

            while (a > 0)
            {
                qaliq = a % 10;//97531
                a = (a - qaliq) / 10;
                netice1 = netice1*10 + qaliq;
            }
            Console.WriteLine(netice1);
        }
    }
}
