using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birim Fiyatı giriniz/enter price :");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.Write("Adet giriniz/enter piece :");
            int piece = Convert.ToInt32(Console.ReadLine());
            int total = piece * price;
            if (price < 1)
                Console.WriteLine("Geçersiz birim fiyat.Lütfen tekrar deneyiniz/invalid price , please try again");
            else
            {
                Console.WriteLine("Ürünü girişi başarılı/success");
                Console.WriteLine("Ürünü toplam fiyatı/total price = "+total);
            }
            Console.ReadKey();

        }
    }
}
