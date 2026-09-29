using System;

namespace TugasUTBK
{
    class home
    {
        static void Main(string[] args)
        {
            int matematika = 95;
            int Binggris = 89;
            int mapelpilihan = 95;

            int totalnilaitka = matematika + Binggris + mapelpilihan;

            Console.WriteLine("syarat masuk UTS");

            Console.WriteLine("Nilai matematika =" + matematika);
            Console.WriteLine("Nilai Binggris =" + Binggris);
            Console.WriteLine("Nilai mapelpilihan =" + mapelpilihan);

            Console.WriteLine("total nilai TKA =" + totalnilaitka);

            Console.WriteLine("Jalur Prestasi");

            if (totalnilaitka >= 280)
            {
                Console.WriteLine("Memenuhi Syarat");
            }
            else
            {
                Console.WriteLine("Tidak memnuhi syarat");
            }

            double totalnilai30tka = totalnilaitka * 0.3;
            double totalnilaiutbk = 600 - totalnilai30tka;

            Console.WriteLine("Jalur UTBK");

            Console.WriteLine("nilai tka dari 30% =" + totalnilai30tka);
            Console.WriteLine("total nilai UTBk =" + totalnilaiutbk);

        }
    }

}