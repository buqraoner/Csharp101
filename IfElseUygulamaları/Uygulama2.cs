using System;

namespace IFEL

{
    class Program
    {
        static void Main(string[]   args){

        ///    bool result = true;
        ///    if(result){ 
        ///        Console.WriteLine("Sonuç 1");
        ///    }
        ///
        ///    else
        ///    {
        ///        Console.WriteLine("Sonuç 2");
        ///    
        ///    }

        int m = 9;
        int n = 7;
        int p = 5;

        if(m>=n && m>=p){
            Console.WriteLine("En Buyuk m");
        }
        if (m>n && !(p>m)){
            Console.WriteLine("En Buyuk m");

        }

        if(m>n || m>p){
            Console.WriteLine("m en kucuk degil!");
        }

        
        

        }
    }
}