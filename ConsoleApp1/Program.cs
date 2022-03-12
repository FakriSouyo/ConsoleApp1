using System;

namespace Algoritma
{
    class Program
    {
        /// <summary>
        /// Main class
        /// </summary>
        /// <remarks>program dapat beroperasi menghitung penjumlahan deret bilangan jika angka yang dimasukan dari satu sampai dengan sembilan</remarks>
        static void Segitiga(int n)
        {
            /// <summary>
            /// <param name="n">Input angka satu sampai dengan sembilan</param>
            ///<summary>
            string deret = "";
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + deret);
                deret = i + " " + deret;
            }
        }

        static void Main(string[] args)
        {
            
            {
                Console.Write("Masukkan angka: ");
                int n = Convert.ToInt32(Console.ReadLine());

                /// <summary>
                /// </summary>
                /// <param name ="n" >jika n adalah angka satu sampai dengan sembilan maka akan keluar deret angka</param>
                
                if (n >= 1 && n <= 9)
                {
                    Segitiga(n);
                }
                else
                {

                    ///<summary>
                    ///</summary>
                    /// <param name ="n" > jika n adalah bukan angka satu sampai dengan sembilan maka akan keluar harap masukan angka kembali</param>
                    Console.WriteLine("harap masukkan angka 1-9");
                }

                Console.ReadKey();

            }
        }
    }
}

//1. Mulai 
//2. Masukkan n, yaitu angka 1-9
//3. Simpan angka di variabel n
//4. Jika n adalah angka 1-9
//5. Maka, Untuk i = 1, i <= n, i++
//6. Tampilkan i + " " + deret 
//7. Deret = i + " " + deret
//8. Jika n bukan angka 1-9
//9. Maka, tampilkan pesan "harap masukkan angka 1-9"
//10. Selesai

