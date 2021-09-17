using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOdev3
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Console.WriteLine("Bir adet Pozitif tam sayi giriniz   : ");

            int sayitutucu = Convert.ToInt32(Console.ReadLine());

           
            char[] kelimeler = new char[sayitutucu-1];
          






            Console.WriteLine("{0}   >>  Adet Kelimeyi tane tane giriniz ",sayitutucu);
           
            for (int i = 0; i <= kelimeler.Length ; i++)
            {

                Console.WriteLine("Bir kelime giriniz  : ");
                kelimeler[i] = Convert.ToChar(Console.ReadLine()); 
               
            }


            Console.WriteLine("Girdiğiniz kelimeler  ");

            foreach(var kelime in kelimeler)
            {
                Console.WriteLine("{0} ", kelime);


            }
        }

    }


}
