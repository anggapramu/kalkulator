using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Pilih Operasi");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");

            Console.Write("Input Nomor : "); 
            string pilihan = Console.ReadLine();
            int i = Convert.ToInt16(pilihan);
            Console.Write("input nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(i == 1)
                    Console.WriteLine("Hasil pertambahan " + a + " + " + b + " = " + penambahan(a, b));
            if (i == 2)
                Console.WriteLine("Hasil pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
            if (i == 3)
                Console.WriteLine("Hasil perkalian " + a + " x " + b + " = " + perkalian(a, b));
            if (i == 4)
                Console.WriteLine("Hasil pembagian " + a + " / " + b + " = " + pembagian(a, b));
            else
                Console.WriteLine("Pilihan salah");
            Console.WriteLine("Tekan Tombol Sembarang untuk keluar....");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}