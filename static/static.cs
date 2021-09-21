class Ogrenci
{
    public static int OgrenciSayisi = 0;
    public string AdiSoyadi;
    public int Numara;
    public Ogrenci()
    {
        OgrenciSayisi++;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Static elemanlara sınıf adı ile erişilir. 
        // Öğrenci Sayısı:0
        Console.WriteLine("Öğrenci Sayısı:{0}",Ogrenci.OgrenciSayisi);
        // Static olmayan elemanlara nesne oluşturularak erişilir.
        Ogrenci ogr1 = new Ogrenci();
        ogr1.AdiSoyadi = "Serdar Yılmaz";
        ogr1.Numara = 134;
        Ogrenci ogr2 = new Ogrenci();
        ogr2.AdiSoyadi = "Cansu Sefil";
        ogr2.Numara = 155;
        // Öğrenci Sayısı:2
        Console.WriteLine("Öğrenci Sayısı:{0}", Ogrenci.OgrenciSayisi);
    }
}