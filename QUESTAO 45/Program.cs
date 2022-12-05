using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;

            Console.WriteLine("Quantos números deseja digita?: ");
            qtd = int.Parse(Console.ReadLine());

            int[] num = new int[qtd];

            for (int x = 0; x < qtd; x++)
            {
                Console.WriteLine($"Digite o {x + 1}º Número: ");
                num[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A ordem contrária é: ");
            for (int y = qtd - 1; y >= 0; y--)
            {
                Console.WriteLine(num[y]);
            }
            Console.ReadLine();
        }
    }
}
