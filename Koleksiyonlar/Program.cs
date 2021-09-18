using System;
using System.Collections.Generic;
using System.IO;


namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> phoneBook = new Dictionary<string, int>(N);
        for (int i = 0; i < N; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            if (temp[1].Length == 8)
            {
                phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
            }
        }
        string nameToSearch = "";
        while ((nameToSearch = Console.ReadLine()) != null)
        {
            int flagFound = 0;
            if (nameToSearch != "")
            {
                if (phoneBook.ContainsKey(nameToSearch))
                {
                    flagFound = 1;
                }
            }
            if (flagFound == 1)
            {
                Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

                //            var salmons = new List<string>();
                //salmons.Add("chinook");
                //salmons.Add("coho");
                //salmons.Add("pink");
                //salmons.Add("sockeye");


                // Create a list of strings by using a
                //// collection initializer.
                //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
                //
                //// Iterate through the list.
                //foreach (var salmon in salmons)
                //{
                //    Console.Write(salmon + " ");
                //}
                //// Output: chinook coho pink sockeye




                //                // Create a list of strings by using a
                //// collection initializer.
                //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
                //
                //for (var index = 0; index < salmons.Count; index++)
                //{
                //    Console.Write(salmons[index] + " ");
                //}
                //// Output: chinook coho pink sockeye



                // Create a list of strings by using a
                // collection initializer.
                //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

                //// Remove an element from the list by specifying
                //// the object.
                //salmons.Remove("coho");
                
                //// Iterate through the list.
                //foreach (var salmon in salmons)
                //{
                //    Console.Write(salmon + " ");
                //}
                 //// Output: chinook pink sockeye




        }
    }
}
