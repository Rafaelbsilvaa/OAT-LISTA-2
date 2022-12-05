using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;
            double media = 0;

            Console.WriteLine("Digite a quantidade de números: ");
            qtd = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtd];
            for (int x=0; x<qtd; x++)
            {
                Console.WriteLine($"Digite o valor {x + 1}: ");
                numeros[x] = int.Parse(Console.ReadLine());
                media += numeros[x];
            }
            media = media / qtd;
            Array.Sort(numeros);

            Console.WriteLine($"A média dos valores é: {media} O maior valor é: {numeros[qtd -1]}");    
            Console.ReadLine();
        }
    }
}
