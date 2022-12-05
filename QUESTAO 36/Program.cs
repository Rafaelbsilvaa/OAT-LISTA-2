using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd = 10;
            double media = 0;
            int[] num = new int[qtd];

            for (int x = 0; x < qtd; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + " º número:");
                num[x] = int.Parse(Console.ReadLine());
                media += num[x];
            }
            media = media / qtd;
            Array.Sort(num);

            Console.WriteLine("O menor número é: " + num[0]);
            Console.WriteLine("O maior número é " + num[qtd - 1]);
            Console.WriteLine("A média dos números é: " + media);
            Console.ReadLine();
        }   
    }
}
