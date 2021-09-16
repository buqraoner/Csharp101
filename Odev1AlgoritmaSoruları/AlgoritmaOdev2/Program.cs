using System;
using System.Collections;

namespace AlgoritmaOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //  Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //  Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
           

            Console.WriteLine("İki adet sayi giriniz : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Girdiğiniz sayilar : {0} değerinden büyük olmalı  ", m);

            ArrayList sayitutucu = new ArrayList();

            for ( int i = 0; i <n; i++)
            {
                int sayac = Convert.ToInt32(Console.ReadLine());

                if (sayac % m == 0)
                {
                    sayitutucu.Add(sayac);

                }
            }

            foreach (var sayilar in sayitutucu)
            {

                Console.Write(sayilar + " ");
            }




        }
    }
}
