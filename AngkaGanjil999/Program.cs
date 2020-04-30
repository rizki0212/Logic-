using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngkaGanjil999
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
                if (i % 2 == 0)
                {
                    arr[i] = 999;
                   
                }
                else
                {
                    arr[i] = i + 1;
                }

                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
