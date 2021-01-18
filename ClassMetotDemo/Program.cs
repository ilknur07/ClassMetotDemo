using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0123456789;
            musteri1.Adi = "Hasibe";
            musteri1.SoyAdi = "Senel";
            musteri1.Yasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 9876543210;
            musteri2.Adi = "Kerem";
            musteri2.SoyAdi = "Aksoy";
            musteri2.Yasi = 22;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri2);








        }
    }
}
