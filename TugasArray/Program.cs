using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa1 = new Mahasiswa { Nomer = 1, Nama = "John Doe", Nilai = 44};
            Mahasiswa mahasiswa2 = new Mahasiswa { Nomer = 2, Nama = "Jane Smith", Nilai = 66 };
            Mahasiswa mahasiswa3 = new Mahasiswa { Nomer = 3, Nama = "Alice Johnson", Nilai = 77 };

            Mahasiswa[] arrayMahasiswa = { mahasiswa1, mahasiswa2, mahasiswa3 };

            foreach (Mahasiswa mahasiswa in arrayMahasiswa)
            {
                Console.WriteLine("Nomor: " + mahasiswa.Nomer);
                Console.WriteLine("Nama: " + mahasiswa.Nama);
                Console.WriteLine("Nilai: " + mahasiswa.Nilai);
                Console.WriteLine();
            }
        }
    }
}









