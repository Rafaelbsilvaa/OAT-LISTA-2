using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Console.WriteLine("Quantos números deseja adicionar?:");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] num = new int[qtd];
            for (int x = 0; x < num.Length; x++)
            {
                Console.WriteLine("Digite o {x +1}° número:");
                num[x] = int.Parse(Console.ReadLine()); 
            }
            for (int x = 0; x < num.Length;x++)
            {
                long resultado = 1;
                for (long y = num[x]; y > 0; y--)
                {
                    resultado = y * resultado;
                }
                Console.WriteLine($"O fatorial de {num[x]} é: {resultado}");

            }
            Console.ReadLine();
        }
    }
}
