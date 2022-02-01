using System;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13) 3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.
*/
            int a = 12345;
            int qaliq;
            int b = 54321;
            int qaliq2;
            int c = 12354;
            int qaliq3;
            int d;
            int percent;
            bool isSucces = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c>=10000 && c<100000;
            if (isSucces == false)
            {
                Console.WriteLine("Verilen 5 reqemli deyil");
                return;
            }
            qaliq = a % 10;                        //5
            a = (a- (a % 10000))/10000;           //1
            a = a*10 + qaliq;                    //15

            qaliq2 = b % 10;                   //1
            b = (b - (b % 10000)) / 10000;    //5
            b = b * 10 + qaliq2;             //51

            qaliq3 = c % 10;               //4
            c = (c - (c % 10000)) / 10000;//1
            c = c * 10 + qaliq3;         //14

            d = a + b + c;
            percent = d * 50 / 100;
            d = d + percent;
            Console.WriteLine(d);

        }
    }
}
