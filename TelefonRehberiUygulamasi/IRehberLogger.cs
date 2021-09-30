using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public interface IRehberLogger
    {
        void Ekle(Kisi kisi);
        void Sil(Kisi kisi);
        void Güncelle(Kisi kisi);
        List<Kisi> Listele();
        void Bul(Kisi kisi);
    }
}
