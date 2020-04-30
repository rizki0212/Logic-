using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanjilGenapMinus
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
                if (i % 2 ==0)
                {
                    arr[i] = (i * 2) + 1;
                }
                else
                {
                    arr[i] = (i * 2 + 1)* -1;
                }
               
                Console.Write(arr[i] + " ");
            }
        }
    }
}
