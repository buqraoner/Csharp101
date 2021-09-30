using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
   public  class RehberManager : IRehberLogger
    {
        private int _sayi;

        public List<Kisi> _kisiler;

        public RehberManager()
        {
            _kisiler = new List<Kisi>{
            new Kisi{ Ad = "Emre", Soyad = "Celik", Numara = 15325 },
            new Kisi{ Ad = "Ali ", Soyad = "Yılmaz", Numara = 546854 },
            new Kisi{ Ad = "Veli", Soyad = "Öztürk", Numara = 96148 },
            new Kisi{ Ad = "Mehmet", Soyad = "Küçük", Numara = 602315 },
            new Kisi{ Ad = "Ceyhun", Soyad = "Şensoy", Numara = 45614880 },};
            foreach (var kisiler in _kisiler)
            {

                System.Console.WriteLine(kisiler.Ad + " " + kisiler.Soyad + " " + kisiler.Numara);
            }



            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemek");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");
            _sayi = Convert.ToInt32(Console.ReadLine());
            if (_sayi == 1)
            {
                Ekle(new Kisi());
            }
            else if (_sayi == 2)
            {
                Sil(new Kisi());
            }
            else if (_sayi == 3)
            {
                Güncelle(new Kisi());
            }
            else if (_sayi == 4)
            {
                Listele();
            }
            else if (_sayi == 5)
            {
                Bul(new Kisi());
            }

        }




        public void Bul(Kisi kisi)
        {
            System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n***********************\n\nİsime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");

            _sayi = Convert.ToInt32(Console.ReadLine());

            if (_sayi == 1)
            {
                System.Console.WriteLine("Lütfen kişi adını veya soyadını giriniz.");
                kisi.Ad = Console.ReadLine();

                for (int i = 0; i < _kisiler.Count; i++)
                {
                    if ((_kisiler[i].Ad == kisi.Ad || _kisiler[i].Soyad == kisi.Ad))
                    {
                        System.Console.WriteLine(_kisiler[i].Ad + " " + _kisiler[i].Soyad + " " + _kisiler[i].Numara);
                    }

                }
            }

            else if (_sayi == 2)
            {
                System.Console.WriteLine("Lütfen kişi numarasını giriniz.");
                kisi.Numara = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < _kisiler.Count; i++)
                {
                    if (_kisiler[i].Numara == kisi.Numara)
                    {
                        System.Console.WriteLine(_kisiler[i].Ad + " " + _kisiler[i].Soyad + " " + _kisiler[i].Numara);
                    }

                }

            }

        }

        public void Ekle(Kisi kisi)
        {
            System.Console.WriteLine("Lütfen kişi adını giriniz.");
            kisi.Ad = (Console.ReadLine());

            System.Console.WriteLine("Lütfen kişi soyadını giriniz.");
            kisi.Soyad = (Console.ReadLine());

            System.Console.WriteLine("Lütfen kişi numarasını giriniz.");
            kisi.Numara = Convert.ToInt32(Console.ReadLine());

            _kisiler.Add(kisi);
            foreach (var item in _kisiler)
            {
                System.Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Numara);
            }
        }

        public void Güncelle(Kisi kisi)
        {
            System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını giriniz:");
            kisi.Ad = Console.ReadLine();
            for (int i = 0; i < _kisiler.Count; i++)
            {
                if (_kisiler[i].Ad == kisi.Ad)
                {
                    System.Console.WriteLine(kisi.Ad + " " + "isimli kişinin numarası güncellenmiştir.");
                }
                else
                {
                    System.Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.\n * Güncellemeyi sonlandırmak için    : (1)\n * Yeniden denemek için              : (2)");
                    _sayi = Convert.ToInt32(Console.ReadLine());
                    if (_sayi == 1)
                    {
                        break;
                    }
                    else if (_sayi == 2)
                    {
                        Güncelle(kisi);
                    }
                }
            }
        }

        public List<Kisi> Listele()
        {
            System.Console.WriteLine("Telefon Rehberi\n**********************************");
            for (int i = 0; i < _kisiler.Count; i++)
            {
                System.Console.WriteLine("İsim:" + _kisiler[i].Ad + "\n" + "Soyisim:" + _kisiler[i].Soyad + "\n" + "Numara:" + _kisiler[i].Numara + "\n" + "-");
            }
            return _kisiler;
        }

        public void Sil(Kisi kisi)
        {
            System.Console.WriteLine("Lütfen silmek istediğiniz kişinin adını giriniz.");
            kisi.Ad = Console.ReadLine();
            for (int i = 0; i < _kisiler.Count; i++)
            {
                if (_kisiler[i].Ad == kisi.Ad)
                {
                    _kisiler.Remove(_kisiler[i]);
                    System.Console.WriteLine(kisi.Ad + " " + "isimli kişi rehberden silinmiştir.");
                }
                else
                {
                    System.Console.WriteLine("Rehberde yok.");
                }
            }

            foreach (var item in _kisiler)
            {
                System.Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Numara);
            }
        }
    }












}

    

