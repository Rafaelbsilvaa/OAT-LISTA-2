using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, Result = 0;

            do
            {
                Console.WriteLine("Digite um númeor maior que 0 e menor que 10: ");
                num = int.Parse(Console.ReadLine());

            } while (num <= 0 || num >= 10);

            for ( int x = num; x < 40 + num; x++ )
            {
                if ( x % 2 == 1)
                {
                    Result += x * x;
                }
            }Console.WriteLine($"O resultado da soma do numero informado é: {Result}");
             Console.ReadLine();
        }
    }
}
