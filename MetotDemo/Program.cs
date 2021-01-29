using System;

namespace MetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Y_Ad = "Admin";
            string Y_Sifre = "12345";
            Console.WriteLine("--------------------------");
            Console.WriteLine("Salih Bank'a Hoş Geldiniz");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lütfen Giriş Bilgileriniz Giriniz");
            bool durum = true;
            while (durum == true)
            {
                Console.Write("Kullanıcı Adınız:");
                string G_Ad = Convert.ToString(Console.ReadLine());
                Console.Write("Kullanıcı Şifreniz:");
                string G_Sifre = Convert.ToString(Console.ReadLine());
                if (Y_Ad == G_Ad && Y_Sifre == G_Sifre)
                {
                    Console.WriteLine("Giriş Başarıyla Yapıldı");
                    durum = false;
                }
                else
                {
                    Console.WriteLine("Giriş Hatalı Lütfen Tekrar Deneyiniz");
                }
            }
            MusteriMenager operation = new MusteriMenager();
            Musteri[] details = new Musteri[20];
            bool control = true;
            while (control)
            {

                Console.WriteLine("Aşağıdan Yapmak İstediğiniz İşlemi Seçiniz");

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1)Müşteri Ekleme \n" +
                    "2)Müşteri Silme \n" +
                    "3)Müşteri Listeleme \n" +
                    "4)Müşteriye Bakiye Ekleme/Çıkarma \n" +
                    "5)Çıkış");
                Console.WriteLine("----------------------------------------------");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 5)
                {
                    control = false;
                    break;
                }
                else if (secim == 1)
                {
                    operation.Ekle();
                }
                else if (secim == 2)
                {
                    operation.Sil();
                }
                else if (secim == 3)
                {
                    operation.Listele();
                }
                else if (secim == 4)
                {
                    operation.Bakiyeİslemleri();
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız Lütfen Tekrar Deneyiniz");
                }
            }
            Console.ReadLine();
        }
    }
}
