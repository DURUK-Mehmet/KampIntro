using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //<T> ifadesi oluşturulacak olan nesnenin tipi
    {
        T[] items; //T tipinde Arrays oluşturmamız gerek

        public MyList() //Constructor
        {
            //MyList ten bir nesne oluşturulduğu anda(MyList'i new'lemek) items 0 elamanlı oluyor
            items = new T[0];
        }
        public void Add(T item) //T ne ise Add i kullanmak için o tipte bir ifade gönderilmeli
        {
            T[] tempArray = items; //geçici tempArray oluşturup items elamanlarını içine atarız
            items = new T[items.Length + 1]; //items eleman saysını 1 artırırız
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i]= tempArray[i]; //tempArray daki sıralı elemanları tekrar items e sırasıyla atarız
            }
            items[items.Length-1]= item; //5 eleman yaptığımızda 4. indisine elaman atarız bu yüzden -1 yazıldı
                                         //Burada dışarıdan gelen item items in son indisine atılır
        }
    }
}
