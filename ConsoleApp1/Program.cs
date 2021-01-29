using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.Write("Kaç Adet Ürün Kayıt Alınacak:");
            int miktar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");
            URUN[] liste = new URUN[miktar];



            for (int i = 0; i < miktar; i++)
            {
                URUN p1 = new URUN();
                Console.Write("{0}.Ürün Adı Giriniz:", i + 1);
                p1.U_Adi = Convert.ToString(Console.ReadLine());
                Console.Write("{0}.Ürün Detayı Giriniz:", i + 1);
                p1.U_Detay = Convert.ToString(Console.ReadLine());
                Console.Write("{0}.Ürün Miktarı Giriniz:", i + 1);
                p1.U_Miktar = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}.Ürün Fiyatı Giriniz:", i + 1);
                p1.U_Fiyat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------");
                liste[i] = p1;
            }
            int sayac = 1;
            foreach (URUN j in liste)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(sayac + ".Ürün Adı:{0}", j.U_Adi);
                Console.WriteLine(sayac + ".Ürün Detayı:{0}", j.U_Detay);
                Console.WriteLine(sayac + ".Ürün Miktarı:{0}", j.U_Miktar);
                Console.WriteLine(sayac + ".Ürün Fiyatı:{0}", j.U_Fiyat);
                Console.WriteLine("--------------------");
                sayac++;
            }
            Console.ReadLine();
        }
    }
    class URUN
    {
        public string U_Adi { get; set; }
        public string U_Detay { get; set; }
        public int U_Miktar { get; set; }
        public int U_Fiyat { get; set; }
    }

}