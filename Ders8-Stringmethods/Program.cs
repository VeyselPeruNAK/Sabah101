using System;

namespace Ders8_Stringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string birlesim = String.Concat("Smart", "Pro", "405Sabah", 2022);
            //Console.WriteLine(birlesim);
            //int[] dizi = { 3, 4, 5, 6 };
            //Console.WriteLine(   String.Concat(dizi) );

            //string str1 = "KADIKÖY";
            //string str2 = "kadıköy";

            //Console.WriteLine(String.Compare(str1,str2));

            //Console.WriteLine(String.Compare(str1, 1, str2, 1, 3)); // indexten itibaren son int kadar
            //Console.WriteLine(String.Compare(str1, 1, str2, 1, 3, false)); // indexten itibaren son int kadar büyük küçük harf duyarlılığı ayarı

            //string mtn = "BEŞİKTAŞ";
            //Console.WriteLine(mtn.IndexOf("Ş")); // ilk Ş değerinin indexi.
            //Console.WriteLine(mtn.LastIndexOf("Ş")); // son Ş değerinin indexi.
            //Console.WriteLine(mtn.StartsWith("BEŞ")); // BEŞ ile başlıyor mu? 
            //Console.WriteLine(mtn.EndsWith("TAŞ")); // TAŞ ile bitiyor mu? 


            //string yazi = " BFENERBAHÇEB ";
            //yazi = yazi.Trim(); // Baştaki ve sondaki boşlukları siler.
            //Console.WriteLine(yazi);

            //yazi = yazi.Trim('B'); // B karakterini metnin kenarlarından sil.
            //Console.WriteLine(yazi.Trim('B'));
            //char[] dizi = {'H', 'Ç', 'E','A','O' };
            //yazi = yazi.Trim(dizi); // yazıdan listedeki karakterleri metnin kenarlarından siler.
            //Console.WriteLine(yazi);

            //string str3 = "MERHABA DÜNYA";

            //Console.WriteLine(str3.PadRight(15, 'E'));    //15'e tamamlar E ile.
            //Console.WriteLine(str3.PadLeft(15, 'E'));    //15'e tamamlar E ile.
            //// String de yer alan karakterleri silemez yeterli uzunluk verilirse artan alanlara ekler
            ///
            //string youtubeStr = "https://www.youtube.com/watch?v=tbCiWKLLjBY";
            //string[] adres = youtubeStr.Split('=');
            //Console.WriteLine(adres[1]);



            string cumle = "Merhaba arkadaşlar. Bugün sınav var.";
            string[] kelimeler = cumle.Split(' ');
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            //// dizi halindeki verileri birleştirmek için join.

            string yeniCumle = String.Join(' ', kelimeler);
            //Console.WriteLine(yeniCumle);

            //string kucuk = "smartpro";
            //string buyuk = "SMARTPRO";

            //Console.WriteLine(kucuk.ToUpper());
            //Console.WriteLine(buyuk.ToLower());

            //Console.WriteLine(buyuk.Remove(0, 1)); // 0. indisten itibaren 1 eleman sil.
            //Console.WriteLine(buyuk.Insert(5, "_BRO_"));
            //Console.WriteLine(buyuk.Replace('K', 'C'));

            //Console.WriteLine(buyuk.Replace("DEMİ", "OKUL"));

            //string test = "Merhaba Dünya";
            //Console.WriteLine(test.Substring(8)); //Dünya
            //Console.WriteLine(test.Substring(0, 7)); //Merhaba
            //Console.WriteLine(test.Substring(8, 5)); //Dünya

            //Console.WriteLine(test.Contains("Dün")); // Dün yazıda var mı?

            //SORU2: Girilen metindeki kelime sayısını bulan metodu yazınız.(boşluk)

            //SORU3: Girilen metini tersten yazan programı metot kullanarak yazınız.

            //char harf = test[0]; // M
            TersYaz("SMART PRO");

        }
        static int KelimeSay(string yazi)
        {
            int toplamKelime = 0;
            string[] dizi = yazi.Split(' ');
            return dizi.Length - 1;
        }
        static void TersYaz(string yazi)
        {
            for (int i = yazi.Length - 1; i >= 0; i--)
            {
                Console.Write(yazi[i]);
            }
        }
    }
}
