using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("numeros positivos e negativos");

            do
            {
                Console.WriteLine("Digite um número: ");
                Console.WriteLine("Digite 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("O numero é positivo: " +numero);
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O numero é negativo: " +numero);
                }
            } while (numero != 0);
        }
    }
}
