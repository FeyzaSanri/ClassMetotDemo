using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Adi = "Hafsa";
            musteri1.Soyad = "Zorlu";
            musteri1.Id = 154;
            musteri1.Telefon = 5463214576;
            musteri1.Adres = "Esen mahallesi çiğdem sokak 4/1 ";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Gizem";
            musteri2.Soyad = "Saygın";
            musteri2.Id = 123;
            musteri2.Telefon = 5536854128;
            musteri2.Adres = "Atatürk mahallesi paşa sokak 53/5";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Beyza";
            musteri3.Soyad = "Mavi";
            musteri3.Id = 561;
            musteri3.Telefon = 5559835218;
            musteri3.Adres = "Bahçelievler caddesi vatan sokak 19/7";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Telefon);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine("*********");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri1) ;
            musteriManager.Listele(musteri2) ;
            musteriManager.Listele(musteri3) ;
            musteriManager.Sil(musteri3) ;
            
            
            

                
        }
    }
}
