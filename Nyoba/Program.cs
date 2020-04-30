using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyoba
{
    class Program
    {
        static void Main(string[] args)
        {
            int angkaGanjil = 2, angkaGenap = 3;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(angkaGenap + " ");
                    angkaGenap = angkaGenap + 2;
                }
                else
                {
                    Console.Write(angkaGanjil + " ");
                    angkaGanjil = angkaGanjil + 4;
                }
            }
        }
    }
}
