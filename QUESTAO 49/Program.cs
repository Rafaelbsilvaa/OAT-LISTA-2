using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;

            Console.WriteLine("Quantos números deseja inserir?: ");
            qtd = int.Parse(Console.ReadLine());

            int[] v1 = new int[qtd];
            int[] v2= new int[qtd];

            for (int x = 0; x < qtd; x++)
            {
                Console.WriteLine($"Digite um valor para a posição {x + 1} do vetor 1: ");
                v1[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int x =0; x < qtd; x++)
            {
                Console.WriteLine($"Digite um valor para a posição {x + 1} do vetor 2:");
                v2[x] = int.Parse(Console.ReadLine()); 

            }
            Console.WriteLine();
            for(int x = 0; x<qtd; x++)
            {
                if (v1[x]== v2[x])
                {
                    Console.WriteLine($"Valores das Posições {x + 1} dos vetores é igual.");
                    Console.WriteLine($" Valores das Posições {x + 1} dos vetores não são iguais");
                }
            }
            Console.ReadLine();
        }
    }
}
