using System;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
     6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
     Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
     Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
     Neticenin 60 % tap. Cavabin axirina 60 artir.
     Neticeden 18% cix.*/

            int a = 123456;
            int qaliq;
            int netice=0;
            //
            int b = 897654;
            int qaliq2 = 0;
            int netice2=0;
            //
            int c = 646956;
            int qaliq3 = 0;
            int netice3 = 0;
            //
            int d = 1234567;
            int qaliq4;
            int qaliq5;
            int netice4 = 1;
            //
            int cem;
            int k;
            bool isSucces = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d>= 1000000 && d< 10000000;

            if (isSucces==false) {

                Console.WriteLine("verilenler dogru deyil");
                return;
            
            }

            qaliq = a % 1000;
            a = (a - qaliq) / 1000;  //123
            qaliq2= b % 1000;
            b = (b - qaliq) / 1000; //897
            qaliq3 = c % 1000;
            c = (c - qaliq3) / 1000; //646
            qaliq4=d% 10000;
            d= (d-qaliq4) / 10000;
         
            
            while (a>0 && b > 0 && c>0)
            {
                qaliq = a % 10;
                a = (a - qaliq) / 10;
                netice = netice + qaliq;   
                qaliq2 = b % 10;
                b = (b - qaliq2) / 10;
                netice2 = netice2 + qaliq2;
                qaliq3 = c % 10;
                c = (c - qaliq3) / 10;
                netice3 = netice3 + qaliq3;
            }

            while (d > 0)
            {
               qaliq5 = d % 10;
               d = (d - qaliq5) / 10;
               netice4 = netice4 * qaliq5;
            }
             
           cem=netice+netice2+netice3;
           cem=cem+qaliq4;
           cem = cem - netice4;
           cem = (cem * 60) / 100;
           cem = cem * 100 + 60;
           k = cem * 18 / 100;
           cem = cem - k; 

            Console.WriteLine(cem);
            
            
            
           
          
        }
    }
}
