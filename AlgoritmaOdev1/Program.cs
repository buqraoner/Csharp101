using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOdev1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir adet sayi giriniz : ");
            int sayi1 = 0;
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilecek sayi sayisi : {0} ", sayi1);
            int sayi2 = 0;

            ArrayList ciftSayilar = new ArrayList();

            for(int i = 1; i <= sayi1; i++)
            {
               sayi2 = Convert.ToInt32(Console.ReadLine());

                if (sayi2 % 2 == 0)
                {
                    ciftSayilar.Add(sayi2);
                }


            }
            Console.WriteLine(" ");
            foreach(var sayilar in ciftSayilar)
            {

                Console.Write(sayilar + " ");
            }
            

            Console.ReadKey();

        }
    }
}
