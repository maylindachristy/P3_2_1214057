using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = true;
            while (start)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Menu Persegi Panjang");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine(" ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "Hitung Luas":
                        Console.WriteLine("Menghitung luas persegi panjang ");
                        Console.Write("Masukan panjang: ");
                        var panjang = int.Parse(Console.ReadLine());
                        Console.Write("Masukan lebar: ");
                        var lebar = int.Parse(Console.ReadLine());
                        var luas = panjang * lebar;
                        Console.WriteLine("Luas dari persegi panjang adalah " + luas);
                        break;

                    case "hitung luas":
                        Console.WriteLine("Menghitung luas persegi panjang ");
                        Console.Write("Masukan panjang: ");
                        var panjang3 = int.Parse(Console.ReadLine());
                        Console.Write("Masukan lebar: ");
                        var lebar3 = int.Parse(Console.ReadLine());
                        var luas2 = panjang3 * lebar3;
                        Console.WriteLine("Luas dari persegi panjang adalah " + luas2);
                        break;

                    case "Hitung Keliling":
                        Console.WriteLine("Menghitung keliling persegi panjang");
                        Console.Write("Masukan panjang: ");
                        var panjang2 = int.Parse(Console.ReadLine());
                        Console.Write("Masukan lebar: ");
                        var lebar2 = int.Parse(Console.ReadLine());
                        int keliling = (panjang2 * 2) + (lebar2 * 2);
                        Console.WriteLine("Keliling dari persegi panjang adalah " + keliling);
                        break;

                    case "hitung keliling":
                        Console.WriteLine("Menghitung keliling persegi panjang");
                        Console.Write("Masukan panjang: ");
                        var panjang4 = int.Parse(Console.ReadLine());
                        Console.Write("Masukan lebar: ");
                        var lebar4 = int.Parse(Console.ReadLine());
                        int keliling2 = (panjang4 * 2) + (lebar4 * 2);
                        Console.WriteLine("Keliling dari persegi panjang adalah " + keliling2);
                        break;

                    default: Console.WriteLine("Input tidak valid"); break;
                }
                Console.Write("Apakan anda ingin mengulangi lagi? (Y/T): ");
                var input = Console.ReadLine();
                if (input == "T" || input == "t")
                {
                    Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                    start = false;
                }
                else
                {
                    start = true;
                }
            }
        }
    }
}
