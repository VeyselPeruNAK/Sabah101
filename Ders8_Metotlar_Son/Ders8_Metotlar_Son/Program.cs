using System;

namespace Ders8_Metotlar_Son
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(7,8,3,4,5));
            Console.WriteLine(Topla(7,8));//default olarak alttaki Topla
                                          // yani normal parametreli metot
                                          // çağrılır.

            Console.WriteLine(PuanTopla("Mehmet",25,12,34,56,77));
            Console.WriteLine("En büyük sayı=" + 
                EnBuyukSayiyiBul(1,2,5,9,12,66,34,35,65));
        }

        private static int EnBuyukSayiyiBul(params int[] sayilar)
        {
            int enBuyukSayi = -1;
            foreach (var item in sayilar)
            {
                if (enBuyukSayi < item)
                    enBuyukSayi = item;
            }
            return enBuyukSayi;
        }

        private static int PuanTopla(string ad, int yas,params int[] puanlar)
        {
            int toplam = 0;
            Console.WriteLine("Adı: " + ad);
            Console.WriteLine("Yaşı:" + yas);
            foreach (var item in puanlar)
            {
                toplam += item;
            }
            return toplam;
        }

        private static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Params kullanan metot çağrıldı");
            return toplam;
        }
        //Params parametreleri normal parametreler ile birlikte
        //kullanılırken, params en sağa yazılır. 
        private static int Topla(int v1, int v2)
        {
            Console.WriteLine("Normal parametreli metot çağrıldı");
            return v1 + v2;
        }

    }
}
