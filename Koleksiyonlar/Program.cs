using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Salih";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// burayı yazdırmayacak nedeni ise 15. satırdaki new ile yeni bir isimler dizisi oluşturuyoruz ve önceki elemanlar içerisinde yok



            //List seçeneği 

            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");
            //isimler2.Add("Murat");
            //isimler2.Add("Kerem");
            //isimler2.Add("Halil");

            //Yukarıdaki ve aşağıdaki kod satırları aynı işleve yarar
            
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Salih");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



            Console.ReadLine();
        }
    }
}
