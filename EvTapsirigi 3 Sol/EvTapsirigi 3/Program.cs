using System;

namespace EvTapsirigi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) verilmish 4 reqemli ededin reqemlerinin cemini tap*/

            int a = 1234;
           int qaliq;
           int netice = 0;
               
            while (a>0)
            {

                qaliq = a % 10; //4
                    a = (a - qaliq)/10;
                    netice = netice + qaliq;
                    Console.WriteLine(netice);

                
            }



            
            
        }
    }
}
