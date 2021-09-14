using System;
{

    class Program
    {

        static void Main(string[] args)
        {



            string ifade = " Buğra Ahmet Öner";
            Console.WriteLine(ifade.Checkspaces());
            bool sonuc = = ifade.Checkspaces();
            Console.WriteLine(sonuc);


            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());
                Console.WriteLine(ifade.GetFirstCharacter());
            }
        }
    }


    public static class Extension
    {

        public static bool Checkspaces(this string param)
        {
            param.Consotain(" ");
        }

        public static string RemoveWhiteSpaces(this string param){

            string[] dizi = param.Split(" ");
            return string.Join("",Dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }


            public static string MakeLowerCase(this string param)
            {

                return param.ToLower();

            }

            public static string GetFirstCharacter(this string param){

                return param.Substring(0,1);

            }
    }
}