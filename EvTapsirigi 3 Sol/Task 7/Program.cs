using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir*/
            int verilen = 1234;
            bool dogru = verilen >= 1000 && verilen < 10000;
            if (dogru == false)
            {
                Console.WriteLine("Verilen 4 reqemli deyil");
                return;
            }
            int qaliq;
            int netice=0;
            int netice2=0;

            while (verilen > 0)
            {
            qaliq = (verilen % 10);             //4
            verilen = (verilen - qaliq) / 10;  //123
            netice = (netice * 10) + qaliq;   //4231

                if (netice > 1000)
                {
                    netice2 = ((8 * 10000) + netice) * 10 + 8;
                    Console.WriteLine(netice2);
                }

           
            }
        
        }  

    }
}
