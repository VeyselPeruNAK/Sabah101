using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_MetotlarTekrar
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
            //Merhaba(); // Metodu çağıdık.

            ToplaYaz(10, 90);

            int toplam = ToplaDondur(15, 25);
            //Console.WriteLine($"15 ve 25'in toplamı = {toplam}");

            // 5 yazı girilsin. Ekrana girilenleri yazalım.
            List<string> gelenYazilar = CokYaz(5);
            //for (int i = 0; i < gelenYazilar.Count(); i++)
            //{
            //    Console.WriteLine(gelenYazilar[i]);
            //}

            Topla(5, 3); // opsiyonları kullanmadık.
            //Topla(9); // s1 için 9 girdik. s2 varsayılan 20 olarak kaldı.
            //Topla(s2: 45); // s1 için değer girmedik. s2 için 45 değerini gönderdik.
            //Topla(); // s1 ve s2 için değer girmedik.

            PersonelEkle(7173678734, "Mehmet Demir", "istanbul...", "0546...");
            PersonelEkle(77777777777, "Hasan Emir", "istanbul...", "0532...");
            PersonelEkle(88888888888, "Ahmet Çelik", "istanbul...", "0533...");
            PersonelEkle(66666666666, "Hüseyin Temiz", "istanbul...", "0505...");
            PersonelEkle(88888888888, "Onur Bakır", "istanbul...", "0506...");
            PersonelSil(66666666666);
            string s = PersonelAra(66666666666);
            if (s == "")
                Console.WriteLine("66666666666 TC'li personel bulunamadı.");
            else
                Console.WriteLine(s);
            s = PersonelAra(88888888888);
            Console.WriteLine(s);


            //PersonelGuncelle(TC: 7173678734, adSoyad = "Ahmet Demir");
            string ad = "Ahmet Çelik123";
            string bulunanPersonel = PersonelAra(adSoyad: ad); // named parametre ile arayacak.
            if (bulunanPersonel != "")
                Console.WriteLine("Bulunan personel = " + bulunanPersonel);
            else
                Console.WriteLine(ad + " adlı personel bulunamadı.");

            ad = "Ahmet Çelik";
            bulunanPersonel = PersonelAra(adSoyad: ad); // named parametre ile arayacak.
            if (bulunanPersonel != "")
                Console.WriteLine("Bulunan personel = " + bulunanPersonel);
            else
                Console.WriteLine(ad + " adlı personel bulunamadı.");


            // Liste içinde Liste...
            //List<object> listem = new List<object>();
            //List<int> sayilarim1 = new List<int> { 23, 34, 45 };
            //List<int> sayilarim2 = new List<int> { 65, 54, 21 };
            //listem.Add(sayilarim1);
            //listem.Add(sayilarim2);

            //foreach (List<int> liste in listem)
            //{
            //    foreach (var item in liste)
            //    {
            //        Console.Write(item);
            //    }
            //    Console.WriteLine();
            //}




            TCler.Add(1);
            adSoyadlar.Add("Nihal");
            adresler.Add("Kadıköy Caferağa mahallesi.");
            telefonlar.Add("0546123123");

            string bulunan = PersonelAra(adSoyad: "Nihal");
            Console.WriteLine(bulunan);



        }

        // Değer döndürmeyen, parametre almayan metot. 
        static void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }

        // Değer döndüren, parametre almayan metot. 
        static string MerhabaDondur()
        {
            return "Merhaba"; // string tipinde veri döndürdük.
        }

        // Değer döndürmeyen, parametre alan metot. 
        static void ToplaYaz(int sayi1, int sayi2)
        {
            Console.WriteLine($"Toplam = {sayi1 + sayi2}");
        }

        // Değer döndüren, parametre alan metot. 
        static int ToplaDondur(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        // Parametre olarak aldığı kısa kenar ve uzun kenar bilgisi ile dikdörtgenin alan ve çevresini hesaplayıp ekrana yazdıran metodu yazınız. AlanCevreD

        static void AlanCevreD(int kK, int uK)
        {
            int cevre = 2 * (kK + uK);
            int alan = kK * uK;
            Console.WriteLine($"Dikdörtgen alanı = {alan}, çevresi = {cevre}");
        }

        // 1. metot tanımlıyoruz: 1.si Kullanıcıdan veri girişi alan: string. Yaz() kullanıcıdan alınan yazıyı döndürecek. dönüş tipi string. parametre yok.
        // 2. metot cokYaz(int adet) adet sayısın aldığı string değerleri bir liste ile döndürecek.(Yaz metodu ile kullanıcıdan string alınıp listeye atılacak)

        static string Yaz()
        {
            Console.Write("yaz :");
            return Console.ReadLine();
        }

        static List<string> CokYaz(int yaziAdedi)
        {
            List<string> yazilar = new List<string>();
            for (int i = 0; i < yaziAdedi; i++)
            {
                //string yazi=  Yaz();
                //yazilar.Add(yazi);
                yazilar.Add(Yaz());
            }
            return yazilar;
        }

        // Personel Bilgi Sistemi Yapıyoruz
        // TC(long),AdSoyad(string),Adres(string),Telefon(string) için bir veya birer tane liste tanımlayınız.
        // Methotlar: PersonelEkle(gerekli parametreleri alıp ekleme yapacak. başarılı olarak ekleyince true döndürecek)

        // PersonelSil(TC): TC kimlik numarası alınan personel listeden silinecek.başarılı ise true döndürsün.

        // PersonelGuncelle(tc hariç tüm bilgileri opsiyonel olarak alıp güncelleme yapacak. tc + güncellenecek bilgiler.)
        // Personelin eski ve yeni bilgisi string ile alt alta birleştirilerek döndürülsün.
        // PersonelAra(herhangi bir parametre ile arama yapılabilecek.)
        // Personelin tüm bilgileri string olarak döndürülsün.

        // parametrelere varsayılan değer atamak(opsiyonel parametreler)
        static void Topla(int s1 = 10, int s2 = 20)
        {
            if (s2 != 20)
                Console.WriteLine($"{s1} ve {s2} sayılarının toplamları : {s1 + s2}");
        }

        //PersonelAra(tc:1231231);
        //PersonelAra(adSoyad:"Ahmet");
        static string PersonelAra(long tc = 0, string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1; // listede -1. indis olmayacağı için. -1 ise değişmemiştir demek için rastgele verdik.
            if (adSoyad != "")
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
                }
            }
            else if (tc != 0)
            {
                // tc ile ara. personelIndex i değiştir.
                personelIndex = TCler.IndexOf(tc);
            }

            if (personelIndex != -1) // personel bulundu ise.
            {
                personel += Convert.ToString(TCler[personelIndex]) + "  " + adSoyadlar[personelIndex] + "  " + adresler[personelIndex] + "  " + telefonlar[personelIndex] + "\n";
            }
            return personel;

        }

        static void PersonelEkle(long tc = 0, string adSoyad = "", string adres = "", string telefon = "")
        {
            if (tc != 0)
            {
                TCler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }
        static void PersonelSil(long tc = 0)
        {
            if (tc != 0)
            {
                int indis = TCler.IndexOf(tc);
                if (indis != -1)
                {
                    TCler.RemoveAt(indis);
                    adSoyadlar.RemoveAt(indis);
                    adresler.RemoveAt(indis);
                    telefonlar.RemoveAt(indis);
                }
            }
        }



    }
}
