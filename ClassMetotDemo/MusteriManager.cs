using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri:" + musteri.Adi +" "+ musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri:"+musteri.Adi +" " +  musteri.Soyad);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelenen Müşteri:" + musteri.Adi + musteri.Soyad);
        }
    }

    
}
