using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwingli_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// sudah declare variabel.
            //string lampuLaluLintas;

            //Console.Write("lampu warna apa yang anda liat : ");
            //lampuLaluLintas = Console.ReadLine();


            ////statement kontrol. 

            //Console.WriteLine();

            //if (lampuLaluLintas == "merah")
            //{
            //    Console.WriteLine("lampu merah berhenti");// statement.
            //}

            //else if (lampuLaluLintas == "kuning")
            //{
            //    Console.WriteLine("lampu kuning berhati - hati");// statement.
            //}

            //else if (lampuLaluLintas == "hijau")
            //{
            //    Console.WriteLine("lampu hijau berarti jalan");// statement.
            //}

            //deklarasi. 

            //float weight, height;

            //Console.Write("masukkan tinggi badan : ");
            //height = float.Parse(Console.ReadLine());

            //Console.Write("masukkan berat badan : ");
            //weight = float.Parse(Console.ReadLine());

            ////untuk konversi tb.
            //var tempHeight = height / 100;

            ////rumus BMI
            //float BMI = weight / (tempHeight * tempHeight);


            //if (BMI >= 22.9434)
            //{
            //    Console.WriteLine($"BMI dari anda adalah : {BMI}, dan anda terindikasi overweight");
            //}


            //if (BMI <= 18.5434)
            //{
            //    Console.WriteLine($"BMI dari anda adalah : {BMI}, dan anda terindikasi underweight / normal");
            //}

            //label.
            menukopi:

            Console.WriteLine("##  Daftar Menu Kopi Ilkom  ##");
            Console.WriteLine("==============================");

            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Cappuccino");
            Console.WriteLine("3. Moccacino");
            Console.WriteLine("4. Vanilla Latte");
            Console.WriteLine("5. Hazelnut Latte");


            //perlu variabel apa disni ? 

            //int order;

            Console.Write("masukkan pilihan anda : ");
            int order = int.Parse(Console.ReadLine());

            if (order == 1)
            {
                Console.WriteLine("anda memilih Espresso");
            }


            else if (order == 2)
            {
                Console.WriteLine("anda memilih Cappuccino");
            }

            else if (order == 3)
            {
                Console.WriteLine("anda memilih Moccacino");
            }

            else if (order == 4)
            {
                Console.WriteLine("anda memilih Vanilla Latte");
            }


            else if (order == 5)
            {
                Console.WriteLine("anda memilih Hazelnut Latte");
            }


            Console.Write("Ingin memilih menu lain(y/t)? :  ");
            char offer = char.Parse(Console.ReadLine());

            //statement kontrol.

            if (offer == 'y' )
            {
                //...lngsung ke-direct diatas.
                goto menukopi;
            }
            

            else if (offer != 'y' )
            {
                Console.WriteLine("terima kasih.");
            }
        }
 
    }
}
