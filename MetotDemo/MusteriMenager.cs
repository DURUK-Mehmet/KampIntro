using System;
namespace MetotDemo
{
    class MusteriMenager
    {
        int sayac = 0;
        Musteri nesne = new Musteri();
        Musteri[] details = new Musteri[20];

        public void Bakiyeİslemleri()
        {
            Listele();
            Console.Write("Bakiye Eklenecek Kişinin Tc'sini giriniz : ");
            string k_TC=Convert.ToString(Console.ReadLine());
        }
        public void Listele()
        {
            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Müşteri Adı : {0}", details[i].M_Ad);
                Console.WriteLine("Müşteri Soyadı : {0}", details[i].M_Soyad);
                Console.WriteLine("Müşteri Tc : {0}", details[i].M_Tc);
                Console.WriteLine("Müşteri Bakiye : {0}", details[i].M_Bakiye);
            }
        }
        public void Sil()
        {
            Listele();
            Console.Write("Silinecek Kişinin Tc'sini giriniz : ");
            string k_TC = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                
            }
        }
        public void Ekle()
        {
            Console.Write("Müşteri Adı Giriniz : "); nesne.M_Ad = Convert.ToString(Console.ReadLine());
            Console.Write("Müşteri Soyadı Giriniz : "); nesne.M_Soyad = Convert.ToString(Console.ReadLine());
            Console.Write("Müşteri Tc'sini Giriniz : "); nesne.M_Tc = Convert.ToString(Console.ReadLine());
            Console.Write("Müşteri Bakiyesini Giriniz : "); nesne.M_Bakiye = Convert.ToString(Console.ReadLine());
            details[sayac] = nesne;
            sayac++;
        }
    }
}
