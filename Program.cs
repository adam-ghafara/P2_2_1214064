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
            Console.WriteLine("Masukkan Gaji yang akan dihitung...");
            int gaji;
            gaji = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gaji Anda Rp.{gaji}. Anda akan mendapatkan beberapa benefit berikut :");
            int tunjangan;
            tunjangan = gaji / 20;
            int bonus;
            bonus = gaji / 15;
            int pph;
            pph = gaji / 3.5;
            Console.WriteLine($"Tunjangan = Rp.{tunjangan}");
            Console.WriteLine($"Tunjangan = Rp.{bonus}");
            Console.WriteLine($"Tunjangan = Rp.{pph}");
            Console.WriteLine("Adapaun total gaji yang anda dapatkan...");
            int totalgaji;
            totalgaji = gaji + tunjangan + bonus;
            Console.WriteLine($"Total Gaji = {gaji} + {tunjangan} + {bonus} = Rp.{totalgaji}");
            int gajibersih;
            gajibersih = totalgaji - pph;
            Console.WriteLine($"Gaji Bersih = {totalgaji} - {pph} = Rp.{gajibersih}");
            Console.Write("Press enter to Continue...");
            Console.Read();
        }
    }
}
