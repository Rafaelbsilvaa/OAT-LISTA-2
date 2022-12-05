using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x =1; x<= 10;x++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{x} x {i} = {x*i}");
                }
                Console.WriteLine();
            }   Console.ReadLine();
        }
    }
}
