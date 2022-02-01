using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et*/
            int a = 12345678;
            int qaliq;
            bool Dogru = a >= 10000000 && a < 100000000;

            if (Dogru == true)
            { 
            qaliq = a % 10;
            a = (a - qaliq) / 10; //1234567
            a = a % 1000000;
            Console.WriteLine(a);
          
            }
            

        }
    }
}
