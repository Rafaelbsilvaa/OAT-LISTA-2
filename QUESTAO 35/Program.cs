using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 1; num <= 100; num++)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine($"{num} É multiplo de 10 !!");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }Console.ReadLine();
        }
    }
}
