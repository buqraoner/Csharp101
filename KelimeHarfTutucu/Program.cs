using System;

namespace AlgoritmaOdevi4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.



            // Cümledeki toplam kelime tutucu ve harf tutucu
            Console.Write("Bir Cümle giriniz : ");
            string metin = Console.ReadLine();

            string[] ayirici = metin.Split(' ');


            int kelime_tutucu = 0;
            int harf_tutucu = 0;

            foreach (var ayiricilar in ayirici)
            {

                kelime_tutucu++;
                harf_tutucu += ayiricilar.Length;
                

            }



            Console.WriteLine("Cümledeki toplam Kelime sayisi : " + kelime_tutucu);

            Console.WriteLine("Cümledeki toplam harf sayisi : " + harf_tutucu);

            
           
            

            

            


        }

    }

}

