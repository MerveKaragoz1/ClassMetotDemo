using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi--> "+musteri.Ad + musteri.Soyad );
        }
       
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.Id + "\n");
        }

        public void Sil(Musteri musteri)
        {
        
        }
    }
}
