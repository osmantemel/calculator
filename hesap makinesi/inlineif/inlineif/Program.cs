using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlineif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inlineif();
            Console.ReadLine();
        }

        private static void inlineif()
        {
            /* bool katimi = 9 % 3 == 0 ? true : false;
             string ksehir = Console.ReadLine();
             string plaka = ksehir == "istanbul" ? "34" : "0";
             Console.WriteLine(plaka);*/


            /* Console.WriteLine("vize notunu gir");
             float vize = Convert.ToSingle(Console.ReadLine());
             Console.WriteLine("final notunu gir");
             float final = Convert.ToSingle(Console.ReadLine());
             float ort;
             ort = ((40 * vize )+( 60 * final)) / 100;
             string sonuc = ort < 50 ? "kaldınız" : "geçtiniz";
             Console.WriteLine(sonuc);*/


            Console.WriteLine("sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int cevap = sayi % 2 == 0 ? sayi * sayi : sayi *sayi*sayi;
            Console.WriteLine(cevap);
        }
    }
}
