using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalKananAtasKiriBawah
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i == 4 && j == 4) || (i == j) || (i == 9/ 2) || (i + j == 9 - 1) || (j == 9 / 2) || (i == 0) || (j == 0) || (j == 10 - 1) || (i == 10 - 1))
                    { 

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
