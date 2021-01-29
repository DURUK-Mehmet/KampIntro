using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMenager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, "+urun.Adi+ " sepete eklendi");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler, " + urunAdi + " sepete eklendi");
        }
    }
}
