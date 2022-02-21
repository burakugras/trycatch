using System;

namespace trycatchPratik
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girdiğini sayı: " + sayi);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("İşlem tamamlandı.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük yada çok küçük bir değer girdiniz");
                Console.WriteLine(ex);
            }
        }
    }
}
