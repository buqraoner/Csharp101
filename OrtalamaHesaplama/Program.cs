using System;

    /*
            Ortalama Hesaplama
Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

Dikkat Edilmesi Gereken Noktalar :
Kod tekrarından kaçınılmalı
Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
            
    */


namespace OrtalamaHesaplama
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Dizi Derinliği giriniz ");

            int derinlik = Convert.ToInt32(Console.ReadLine());

            int n0 = 0 , n1 = 1;

            Console.Write(n0+ " "+ n1);
          
            int Fibonnaci = 0;

          for (int sayac = 2; sayac<derinlik; sayac++){

            int geciciDegerTutucu = n0+n1;
            
            Fibonnaci+=geciciDegerTutucu;
            Console.Write(" "+ geciciDegerTutucu);
            
            n0 = n1;
            n1 = geciciDegerTutucu;

          }
            Fibonnaci +=1;
            Console.WriteLine("\n ");
            Fibonnaci = Fibonnaci/derinlik;


            Console.Write("Girdiğiniz dizinin ortalaması "+ Fibonnaci);

          
          




 
              




        
        }
    }
}
