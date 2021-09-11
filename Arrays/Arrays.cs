//Array.Sort(sayiDizisi);
//Array.Clear
//Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
//
//Örnek: Aşağıdaki örnek sayi dizisinin 2.indexinden başlayarak 2 tane elemanı temizler.
//
//Array.Clear(sayiDizisi,2,2);
//Array.Reverse
//Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.
//
//Örnek: Array.Reverse(sayiDizisi);
//
//sayiDizisi elemanlarını {1,3,4,9,8,7} olarak düşünürsek; Reverse metodu uygulandığında dizi şöyle olur : {7,8,9,4,3,1}
//
//Array.IndexOf
//Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.
//
//Örnek:
//
//Array.IndexOf(sayiDizisi,7)
//Array.Resize
//Dizileri yeniden boyutlandırmak için kullanılır.
//
//int[] sayiDizisi = {1,3,4,9,8,7};
//Array.Resize<int>(ref sayiDizisi,12);
//sayiDizisi[6] = 10;
//Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 12 elemanlı hale getirildi. Daha sonra 7. elemanına 10 değeri atandı. Diğer boş olan indexlerin değeri ise varsayılan olarak 0 atanır.
//
//int[] sayiDizisi = {1,3,4,9,8,7};
//Array.Resize<int>(ref sayiDizisi,3);
//Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 3 elemanlı hale getirildi. sondaki 3 eleman kırpıldı. Artık dizi şu şekilde: {1,3,4}

using System;

namespace diziler_array_sinifi_metodlari
{
    class Program{

        static void Main(string[]   args)
        {
            //Sort
            
            int[]   sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("**********Sırasız Dizi *******");
            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            Console.WriteLine("*****Sıralı Dizi********");
        
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            // 2.İndexten itibaren 2 elemanı 0'lar
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //IndexOf
             
            foreach (var sayi in sayiDizisi)
            Console.WriteLine( Array.IndexOf(sayiDizisi,23));


            //Resize  Dizinin Boyutunu değiştirme
            Console.WriteLine("**** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]= 99;

            foreach(var sayi in sayiDizisi)
            Console.WriteLine(sayi);



//
          //  {
          //  int[] dizi = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36 };
          //  int gecici;
 //
          //  for (int i = 0; i < dizi.Length / 2;i++)
          //  {
          //      gecici = dizi[i];
          //      dizi[i] = dizi[dizi.Length - i - 1];
          //      dizi[dizi.Length - i - 1] = gecici;
          //  }
          //  foreach(int sayi in dizi)
          //  {
          //      Console.WriteLine(sayi);
          //  }
//
//
          //  

        }
    }
}







