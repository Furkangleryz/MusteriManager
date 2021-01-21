using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriManager
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Müsteri Eklendi : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.TcNo + " " + musteri.Yasi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.TcNo + " " + musteri.Yasi);
        }

        public void MusteriListeleString(Musteri musteri)
        {
            Console.WriteLine("Müsteri sözel olarak Listelendi: " +musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriListeleInt(Musteri musteri)
        {
            Console.WriteLine("Müsteri sayısal olarak Listelendi: " + musteri.TcNo + " " + musteri.Yasi);
        }

    }
}
