using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, "+ musteri.Yasi + " yasinda olan Müsteri: " + musteri.Adi + " " + musteri.SoyAdi + "," + " ID-Numarasi: " + musteri.Id + " ile Sisteme eklenmistir!");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri : " + musteri.Adi + " " + musteri.SoyAdi + "," + " ID-Numarasi: " + musteri.Id  + " ile listelenmistir!");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Yasi + " yasinda olan Müsteri: " + musteri.Adi + " " + musteri.SoyAdi + "," + " ID-Numarasi: " + musteri.Id  + " ile Sistemden silinmistir!");
        }
    }
}
