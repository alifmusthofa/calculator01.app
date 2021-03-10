using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            // int a = 10; // deklarasi variabel a dengan nilai awal 10
            // int b = 6; // deklarasi variabel b dengan nilai awal 6

            Console.WriteLine("Pilih menu calculator:\n");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input nomor menu [1..4] : ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("\n"); // Tambahkan baris kosong

            int a = 0;
            int b = 0;
           
            Console.WriteLine(); // Tambahkan baris kosong

            if (input == 1)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // Proses Casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // Proses Casting

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (input == 2)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // Proses Casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // Proses Casting

                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (input == 3)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // Proses Casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // Proses Casting

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (input == 4)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // Proses Casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // Proses Casting

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak ada");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b) 
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        
    }
}
