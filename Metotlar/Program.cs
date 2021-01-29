using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati =15;
            string detay = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type-safe --- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("**********METOTLAR***********");
            //instance-örnek
            //encapsulation
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);

            sepetMenager.Ekle2("Armut","Yeşil Armut",15);
            sepetMenager.Ekle2("Elma", "Kış elması", 10);
            sepetMenager.Ekle2("Karpuz", "Diyarbakır", 50);


            Console.ReadLine();
        }
    }
}
