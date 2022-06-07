using System;

namespace sifirbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1}.Sayıyı Giriniz:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int adet = 0;
            int toplam = 0;

            foreach (var item in arr)
            {
                if (item.ToString().EndsWith("0"))
                {
                    adet++;
                    toplam += item;
                }
            }

            Console.WriteLine($"Sonu 0 ile biten sayı adeti = {adet}");
            Console.WriteLine($"Sonu 0 ile biten sayıların toplamı = {toplam}");
            Console.ReadKey();

        }
    }
}