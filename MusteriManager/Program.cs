using System;

namespace MusteriManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mustafa";
            musteri1.Soyad = "Koç";
            musteri1.TcNo = 98745632100;
            musteri1.Yasi = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Kaçar";
            musteri2.TcNo = 12345678900;
            musteri2.Yasi = 32;



            Musteri[] musteriler = new Musteri[] {musteri1 , musteri2};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine("-------------------------");
            }

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri2);

            Console.WriteLine("----------------");

            musterimanager.MusteriSil(musteri1);
            musterimanager.MusteriSil(musteri2);

            Console.WriteLine("----------------");

            musterimanager.MusteriListeleString(musteri1);
            musterimanager.MusteriListeleString(musteri2);

            Console.WriteLine("----------------");

            musterimanager.MusteriListeleInt(musteri1);
            musterimanager.MusteriListeleInt(musteri2);

        }
    }
}
