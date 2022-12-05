using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0, Par = 0, Impar = 0, reultpar = 0, reultimpar = 0;

            while (Numero >=0)
            {
                Console.WriteLine("Digite um número (numeros negativos finalizam ): ");
                Numero = int.Parse(Console.ReadLine());
                if (Numero >=0)
                {
                    if (Numero % 2 == 0)
                    {
                        Par++;
                        reultpar += Numero;
                    }
                    else
                    {
                        Impar++;
                        reultimpar+= Numero;
                    }
                }
            }   Console.WriteLine($"Quantidade de Números Pares: {Par} Quantidade de Números Impares: {Impar}");
                Console.WriteLine($"A soma dos Pares: {reultpar} A soma dos Impares: {reultimpar}");
                Console.ReadLine();
        }   
    }
}
