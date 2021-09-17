using System;

namespace HazirMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp,Hoşgeldiniz!";
            string degisken2 = " CSharp";

            // Length;

            Console.WriteLine(degisken.Length);

            //TopUpper ,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat 
            Console.WriteLine(String.Concat(degisken,  " Merhaba!"));


            //Compare,CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            
            // false buyuk kücük harf duyarlı
            // true duyarliConsole.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));


            // IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            Console.WriteLine(degisken.IndexOf("Bugra"));
            //bulamazsa -1
            // İlk indexi verirr... 


            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));
            // 0. İndexten başla Merhaba Ekle 


            //PadLeft  // PadRight ;

            Console.WriteLine(degisken+ degisken2.PadLeft(30));
            Console.WriteLine(degisken+ degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+ degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50,'-')+ degisken2.PadLeft(30,'*'));

            //Remove 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //10.İndexten başla sonuna kadar sil 

            //RePlace 
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "+"));


            //Split

            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));



















            ;



        }
    }
}
