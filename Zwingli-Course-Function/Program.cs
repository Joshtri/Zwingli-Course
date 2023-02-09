using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Zwingli_Course_Function
{
    internal class Program
    {
        //METHOD UTAMA.
        static void Main(string[] args)
        {
            //input panjang sisi dan luas. 

            Console.Write("masukkan panjang sisi : ");
            int sisi = int.Parse(Console.ReadLine());
          
            Console.WriteLine("hasilnya adalah " + HitungLuasPersegi(sisi));

        }

        //pakai method. jenis dibaawah adalah non-void. 
        static int HitungLuasPersegi(int s)
        {
            int luas = s * s;

            return luas;// nilai balik.
        }

    }
}
