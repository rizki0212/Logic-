using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeretKelipatan2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Panjang Angka Yang Mau Dicetak :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];


            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    arr[i] = 1;
                }
                else
                {
                    arr[i] = arr[i - 1] + (i * 2);
                }
               
                Console.Write(arr[i] + " ");
            }
        }
    }
}
