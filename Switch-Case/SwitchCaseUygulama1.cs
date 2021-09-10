using System;

namespace IFEL
{


    class Program{

        public enum Renkler{Kirmizi,Yesil,Mavi}



        static void Main(string[]args){

            Renkler r = (Renkler)(new Random()).Next(0,3);

            switch(r)
            {
                case Renkler.Kirmizi:
                Console.WriteLine("Renk kirmizidir.");
                break;

                case Renkler.Yesil:
                Console.WriteLine("Renk Yesildir.");
                break;

                case Renkler.Mavi:
                Console.WriteLine("Renk Mavidir.");
                break;
                
                default:
            }


        }
    }
}