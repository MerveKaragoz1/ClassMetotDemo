using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Merve";
            musteri1.Soyad = "Karagöz";
            musteri1.Id = 111;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Büşra";
            musteri2.Soyad = "Karagöz";
            musteri2.Id = 222;

            //Musteri[] musteriler = new Musteri[] {musteri1, musteri2};

            /*foreach (Musteri musteri in musteriler)
            {
                 Console.WriteLine(musteri.Ad);
                 Console.WriteLine(musteri.Soyad);
                 Console.WriteLine(musteri.Id);
                 Console.WriteLine("\n");
             }*/

                MusteriManager musteriManagerAdd = new MusteriManager();
                musteriManagerAdd.Ekle(musteri1);
                musteriManagerAdd.Ekle(musteri2);
                Console.WriteLine("\n");
                MusteriManager musteriManagerList = new MusteriManager();
                musteriManagerList.Listele(musteri1);
                musteriManagerList.Listele(musteri2);

                /* MusteriManager musteriManagerRemove = new MusteriManager();
                 musteriManagerRemove.Sil(musteri1);
                 musteriManagerRemove.Sil(musteri12);*/
            
        }
    }
}
