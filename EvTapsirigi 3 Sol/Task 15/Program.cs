using System;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
     /*15)* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.+
     3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.+
     Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.+
     Cavabdan 7 reqemli ededin son 5 reqemini cix.+
     Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.+
     Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.+
     Cavabin axirina 11 artir.+
     Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.+
     Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/
     
            int a = 123;
            int b = 321;
            int c = 123456;
            int d = 654321;
            int e = 1234657;
            int e1 = 1234567;
            int netice;
            int netice2=0;
            int netice3=0;
            int netice4=0;
            int yeni;
            int cem;
            int counter=1;
            int qaliq;
            int qaliq2;
            int qaliq3;
            int qaliq4;
            int qaliq5;
            int qaliq6;
            bool istrue = a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 1000000 && e < 10000000;

            if (istrue == false)
            {
                Console.WriteLine("verilenler dogru deyil");
                return;
            }
            ////// STEP1 ////////
            netice = a + b; //444
            netice = netice % 100;
            netice = netice * netice;
            ////// STEP2 ////////
            yeni = a * 1000 + b;
            netice = netice + yeni;
            ////// STEP3 ////////
            qaliq = e % 100000;              //34657
            netice = netice - qaliq;        //90600    
            ////// STEP4 ////////
            cem = c + d;                   //777777
            qaliq2 = cem % 1000;          //777
            netice = netice + qaliq2;    //91377
            ////// STEP5 //////// 
            while (e > 0)
            {
                qaliq3 = e % 10;
                e = (e - qaliq3) / 10;
                netice2 = netice2  + qaliq3; //28
            }
            while (netice2 > 0) { 
            qaliq4 = netice2 % 10;
            netice2 = (netice2 - qaliq4) / 10;
            netice3 = netice3 * 10 + qaliq4; //82
            }
            netice = netice + netice3;  //91459
            ////// STEP6 //////// 
            netice = netice * 100 + 11; //9145911
            ////// STEP7 //////// 


            while (e1 > 0)                                           
            {                                                       
                qaliq5 = (e1 % 10);//7                               
                e1 = (e1 - qaliq5) / 10;                              
                if (counter % 2 != 0)
                {
                    netice4 = netice4 * 10 + qaliq5;

                }
                    counter ++;

            }

            e1 = netice4;
            netice4 = 0;

            while (e1 > 0)
            {
                qaliq5 = e1 % 10;//97531
                e1 = (e1 - qaliq5) / 10;
                netice4 = netice4 * 10 + qaliq5;
            }
            netice = netice - netice4;//9144554
            //////// STEP 8 ////////
            qaliq6 = netice % 10;
            netice = (netice - qaliq) / 10;
            netice = netice * 100 + 88;
            netice = netice * 10 + qaliq6;
            Console.WriteLine(netice);

        }
    }
}
