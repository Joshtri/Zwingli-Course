using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwingli_Course_array1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data array statis 
            //int[] ageStudent = new int[4] { 50, 10, 20, 10 };
            //ageStudent[4] = 0;


            //data array dinamis

            Console.Write("Input ukuran array : ");
            int arraySize = int.Parse(Console.ReadLine());

            string[] cars = new string[arraySize]; //1D
            Console.WriteLine();


            InputArray(cars);

            Console.WriteLine("Cetak data mobil tahun 2023 : \n\n");
            //cetak.

            //tidak perlu deklarasi. panggil variabel saja. 
            CetakData(cars);
 
        }

        public static void CetakData(string [] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void InputArray(string[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"input data ke-{index} = ");
                array[index] = Console.ReadLine();
            }
        }

        public static void CetakDataint(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void InputArrayint(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"input data ke-{index} = ");
                array[index] = int.Parse(Console.ReadLine());
            }
        }

    }
}
