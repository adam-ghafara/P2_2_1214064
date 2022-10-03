using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Gaji yang akan dihitung
            Console.WriteLine("Masukkan Gaji yang akan dihitung...");
            int gaji;
            gaji = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gaji Pokok Anda Rp.{gaji}. Anda akan mendapatkan Tunjangan dan Bonus berikut :");
            // Sistem Penggajian
            // Hitung Tunjangan, Bonus, dan PPH
            int tunjangan;
            tunjangan = gaji / 20;
            int bonus;
            bonus = gaji / 15;
            double persenpph = 3.5;
            int pphInt = (int) persenpph;
            int pph;
            pph = gaji / pphInt;
            // Output Hasil perhitungan
            Console.WriteLine($"Tunjangan = Rp.{tunjangan}");
            Console.WriteLine($"Bonus = Rp.{bonus}");
            // Hitung total gaji
            Console.WriteLine("Adapaun total gaji yang anda dapatkan...");
            int totalgaji;
            totalgaji = gaji + tunjangan + bonus;
            Console.WriteLine($"Total Gaji = Rp.{gaji} + Rp.{tunjangan} + Rp.{bonus} = Rp.{totalgaji}");
            Console.WriteLine("Adapun Gaji Bersih anda dikurangi PPH...");
            int gajibersih;
            gajibersih = totalgaji - pph;
            Console.WriteLine($"Gaji Bersih = Rp.{totalgaji} - Rp.{pph} = Rp.{gajibersih}");
            Console.Write("Press enter to Continue...");
            Console.Read();
        }
    }
}
