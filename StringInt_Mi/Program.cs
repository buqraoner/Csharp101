using System;

namespace StringInt_Mi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
                 Console.WriteLine("Hello World!");

             

    
        string S = Console.ReadLine();
        
        if(S is string){
            
            Console.WriteLine(S);
        }
        else 
        {
            Console.WriteLine("Bad String");
        }

        }
    }
}



//           class Solution
//   {
//       public static void Main(string[] args)
//       {
//           string S = Console.ReadLine();
//           
//           
//           
//              try
//           {
//               Console.WriteLine(int.Parse(S));
//           }
//           catch (FormatException)
//           {
//               Console.WriteLine("Bad String");
//           } 
//   }
//   
//   }


        






