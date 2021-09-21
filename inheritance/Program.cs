using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
                    //      Canlılar
                    //          bitkiler             hayvanlar                
                    //
                    //
                    //
                    //
                    //Tohumlu           Tohumsuz        sürüngenler 
            TohumluBitkiler tohumluBitki = new tohumluBitki();

            tohumluBitki.Beslenme();
            tohumluBitki.Solunum();
            tohumluBitki.Bosaltim();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();

            Kuslar martı = new Kuslar();
            Martı.Solunum();
            martı.Beslenme();
            martı.Bosaltim();
            martı.Adaptasyon();
            martı.Ucmak();            

        }            
    }            
}         
