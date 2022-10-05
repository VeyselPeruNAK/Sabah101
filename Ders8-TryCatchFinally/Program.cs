using System;

namespace Ders8_TryCatchFinally
{ 
    class Program
{
        static void Main(string[] args)
        {
            // try catch sayesinde hata alma olasılığımız olan kod bloklarını çalıştırmadan önce sağlıklı mı değil mi diye kontrol etmiş oluruz.
            // Hatasız ise try hata var ise catch bloğu çalışır.
            // Eğer eklersek finally bloğu her iki durumda da çalışır.

            int bolunen = 20;
            int bolen = 0;
            try
            {
                int bolum = bolunen / bolen;
                Console.WriteLine(bolum);
            }
            catch (Exception)
            {

                Console.WriteLine("Bir hata ile karşılaşıldı. Ancak program durmadı. Devam ediyor."); ;
            }
            finally
            {
                Console.WriteLine("Try daki blok çalışsa da çalışmasa da çalışan blok.2 durumda da çalışır.");
            }

            //Console.WriteLine("Program bitti.");


            // Spesifik hata yakalama

            int bolunen = 220;
            int bolen = 0;
            int[] dizi = { 1, 2, 3 };
            try
            {
                //int bolum = bolunen / bolen;
                //Console.WriteLine(bolum);
                Console.WriteLine(  dizi[3] ); // olmayan elemana ulşamaya çalıştık.

            }
            catch (DivideByZeroException hata)
            {

                Console.WriteLine($"0'a bölme hatası! Bölen 0 olamaz! {hata.Message}");
            }
            catch (FormatException hata)
            {
                Console.WriteLine($"Format hatası !!{hata.Message}");
            }
            catch (IndexOutOfRangeException indexError)
            {
                Console.WriteLine($"Dizi de olmayan elemana ulaşmaya çalıştın. {indexError.Message}");
            }
            catch (Exception genelHata)
            {
                Console.WriteLine($"Bir hata oluştu {genelHata.Message}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            /*
            int HataVarmi = 0;
            try
            {
                // işlemler
            }
            catch (ArgumentNullException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (ArgumentException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (IndexOutOfRangeException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (FormatException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (DivideByZeroException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (NullReferenceException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (OutOfMemoryException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (InvalidCastException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            
             */

        }


    }
}
