using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Salih";
            musteri1.Soyad = "Duruk";
            musteri1.TcNo = "123456789";
            musteri1.Id = 1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "TheSensei";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();
            //musteri class ı her iki musteri(gercek-tüzel) nesnesini de tutabilir
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




            Console.ReadLine();
        }
    }
}
