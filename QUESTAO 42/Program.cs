using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, maior, menor;
            Console.WriteLine("Digite 0 para sair ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            menor = numero;
            maior = numero;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }

            }while (numero != 0);
            Console.WriteLine($"O maior número digitado é {menor} O menor número digitado é {maior} ");
            Console.ReadLine();
        }
    }
}
