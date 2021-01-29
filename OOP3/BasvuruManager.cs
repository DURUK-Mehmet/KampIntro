using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection 
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        //gelen kredi türüne bağlı olarak aşağıda ona ait hesapla metodu çalışır
        //gelen loggerService türüne bağlı olarak aşağıda ona ait loglama  metodu çalışır
        {
            //Başvuran bilgilerini değerlendirme
            //
            //

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
