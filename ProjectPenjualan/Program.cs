using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();


                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan\n2. Hapus Penjualan\n3. Tampilkan Penjualan\n4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan\n");

            Console.Write("Nota: ");
            penjualan.Kode = Console.ReadLine();
            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            penjualan.Nama = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("Total Nota: ");
            penjualan.Total = Console.ReadLine();




            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Penjualan\n");

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Kode Penjualan: ");
            string kode = Console.ReadLine();
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                if (penjualan.Kode == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\nData penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nNota tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan\n");

            int noUrut = 0;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                noUrut++;
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", noUrut, penjualan.Kode, penjualan.Tanggal, penjualan.Nama, penjualan.Jenis, penjualan.Total);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
