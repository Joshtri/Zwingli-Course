using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zwingli_Course_Bedah_Tugas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nomor 4
            /*
            Console.Write("Masukan panjang sisi : ");
            int sisi = int.Parse(Console.ReadLine());


            HitungLuasVoid(sisi);

            Console.WriteLine($"Hasilnya adalah {HitungLuasNon(sisi)}");
            //Console.WriteLine($"Hasilnya adalah {HitungLuasVoid(sisi)}"); //error.

            */


            //Nomor 5
            /*

            int sisi;
            float d1, d2;

            Console.Write("Masukan sisi : ");
            sisi = int.Parse(Console.ReadLine());

            Console.Write("Masukan panjang diagonal 1 : ");
            d1 = float.Parse(Console.ReadLine());

            Console.Write("Masukan panjang diagonal 2 : ");
            d2 = float.Parse(Console.ReadLine());

            //cara panggil method void.
            LuasKetupatVoid(d1, d2);
            KelilingKetupatVoid(sisi);

            //cara panggil method non-void
            Console.WriteLine($"Luas belah ketupat adalah {LuasKetupatNon(d1,d2)}");
            Console.WriteLine($"Keliling belah ketupat adalah {KelilingKetupatNon(sisi)}");
            */


            //Nomor 6 

            /*
           int p, l, t;

            Console.Write("Masukan panjang : ");
            p = int.Parse(Console.ReadLine());

            Console.Write("Masukan lebar : ");
            l = int.Parse(Console.ReadLine());

            Console.Write("Masukan tinggi : ");
            t = int.Parse(Console.ReadLine());



            volume(p,l,t);
            */

            //Nomor 7

            string friend1, friend2, friend3;

            friend1 = "Rudy";
            friend2 = "Alex";
            friend3 = "Cecep";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(GreetFriendNon(friend1));
            Console.WriteLine(GreetFriendNon(friend2));
            Console.WriteLine(GreetFriendNon(friend3));

        }

        //Method untuk no 7.

        public static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hi {friend}, my friend!");
        }
        public static string GreetFriendNon(string friend)
        {
            return $"Hi {friend}, my friend!";
        }

        //METHOD UNTUK NO 6
        public static void volume(int p, int l, int t) //void.
        {
            int volume = p * l * t;
            Console.Write($"Volume Balok adalah : {volume} ");
        }

        //KERJA YG NON-VOID.



        //METHOD UNTUK NO 5

        public static float LuasKetupatNon(float d1, float d2)//non-void
        {
            float luas = (float)0.5 * d1 * d2;
            return luas;
        }


        public static void LuasKetupatVoid(float d1, float d2) //void
        {

            float luas = (float)0.5 * d1 * d2;
            Console.WriteLine($"Luas belah ketupat adalah {luas}");

        }



        public static void KelilingKetupatVoid(int sisi) //void
        {
            int keliling = 4 * sisi;
            Console.WriteLine($"Keliling belah ketupat adalah {keliling}");
        }


        public static int KelilingKetupatNon(int sisi) //void
        {
            int keliling = 4 * sisi;

            return keliling;
        }


        //METHOD UNTUK NO 4

        public static int HitungLuasNon(int sisi) // non-void.
        {
            int luas = sisi * sisi;
            return luas; //default.
        }

        public static void HitungLuasVoid(int sisi) //void
        {
            int luas = sisi * sisi;
            Console.WriteLine($"Hasilnya adalah {luas}");
        }

    }
}
