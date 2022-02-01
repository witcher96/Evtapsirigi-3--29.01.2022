using System;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    Sonra cavabin ozunden onun 18% ni cix;*/

            int a = 12345678;
            int b;
            int faiz;
            int q1;
            int q2;
            int q3;
            int q4;
            bool istrue = a >= 10000000 && a < 100000000;
            if (istrue == false)
            {
                Console.WriteLine("eded 9 reqemli deyil");
                return;
            }
            q1 = a % 100;//78
            a=(a-q1)/100;
//--------------------------------//
            q2=a%100;//56
            a=(a-q2)/100;
//-------------------------------//
            q3 = a%100;//34
            a=(a-q3)/100;
//-------------------------------//
            q4 = a % 100;//12
            a = (a - q4) / 100;
//-------------------------------//
            b = q1 + q2 + q3 + q4;
            b = b * 100 + 99;
            faiz = b * 18 / 100;
            b = b - faiz;
            Console.WriteLine(b);

        }
    }
}
