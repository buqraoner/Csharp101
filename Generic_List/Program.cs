using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
                     sayiListesi.Add(4);
                     sayiListesi.Add(5);
                     sayiListesi.Add(92);
                     sayiListesi.Add(34);
                     
         List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");           
            renkListesi.Add("Turuncu");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yesil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
        // sayi lsitesinde arama 
         //   if(sayiListesi.Contains(10))
         //   {
         //       Console.WriteLine("10 Liste İçerisinde bulundu!");
         //   }
//
            

        // }


        //Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));


        //Diziyi List'e çevirme
        string[] hayvanlar = {"Kedi","Köpek","Kuş"};




        List<string> hayvanlarListesi = new List<string>(hayvanlar);


        //Listeyi nasıl temizleriz 0
        
        hayvanlarListesi.Clear();

         








    }
}
}
