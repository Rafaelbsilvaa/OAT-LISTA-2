using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Quantos números deseja inserir: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] vetorX = new int[quantidade];
            int[] vetorY= new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                Console.WriteLine($"Digite o {x+1}º Número para o vetor X: ");
                vetorX[x] = int.Parse(Console.ReadLine()) ;
                Console.WriteLine();


            }
            for (int y = 0; y < quantidade; y++)
            {
                Console.WriteLine($"Digite o {y + 1} º Número para o vetor Y: ");
                vetorY[y] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("A multiplicação dos vetores é: ");
            for (int w = 0; w< quantidade; w++)
            {
                Console.WriteLine($"{vetorX[w]} X {vetorY[w]} = {(vetorY[w] * vetorX[w])} ");
            }
            Console.ReadLine();
        }
    }
}
