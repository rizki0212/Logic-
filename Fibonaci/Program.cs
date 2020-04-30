using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Panjang Angka Yang Mau Dicetak :");
            int range = Convert.ToInt32(Console.ReadLine());

            int[] arrFib = new int[range + 1];
            arrFib[0] = 1;
            arrFib[1] = 1;
            for (int m = 1; m < range; m++)
            {
                arrFib[m + 1] = arrFib[m] + arrFib[m - 1]; ;
            }

            for (int o = 0; o < range; o++)
            {
                Console.Write(arrFib[o] + " ");
            }

            
        }
    }
}
