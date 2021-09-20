using System;
using System.Collections;

namespace KoleksiyonlarSoru1
{

    //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)



    // Negatif ve numeric olmayan girişleri engelleyin.
    //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    //
    //
    //
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList asalSayilar   
                = new ArrayList();
            ArrayList asalOlmayanSayilar 
                = new ArrayList();

            Console.WriteLine("20  adet  pozitif sayi giriniz : " );

            // 20 adet sayıyı tutma 

           for(int i =0; i<20; i++)
         {
                

                int z = Convert.ToInt32(Console.ReadLine());

                if (char.IsDigit((char)z))
                { 

                if (z >0) 
                
                
                { 
                
                        // asal bulma 
                for(int bolucu = 2; bolucu<z; bolucu++)
                {
                    if (z % bolucu == 0)
                    {
                        asalOlmayanSayilar.Add(z);

                    }



                    else
                    {

                        asalSayilar.Add(z);
                    }


               
                    }

                }


            }

                else
                {
                    Console.WriteLine("Girdiğiniz değer sayi olmalı ! ");
                }

            }


          
            Console.ReadKey();
            Console.WriteLine("Sayilar girildi .");






            Console.Write("Asal Sayılar : ");



            foreach(var asal in asalSayilar)
            {
                Console.Write(asal);

            }





            Console.ReadKey();
            Console.WriteLine("                    ");


            Console.Write("Asal olmayan Sayılar : ");

            foreach (var oasal in asalOlmayanSayilar)
            {
                Console.Write(oasal);

            }



            Console.WriteLine("Asal ve asal olmayan sayilarin büyükten küçüğe sıralanışı   ");






            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.//
            //
                    //Yapılmadı DEVAMI
            // 


           

        }
    }
}
