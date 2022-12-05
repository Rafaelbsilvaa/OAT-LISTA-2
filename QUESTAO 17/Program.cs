using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Verificador de número:");

            Console.WriteLine("Digite o primeiro número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >=0 && numero <=9)
            {
                Console.WriteLine("Valor válido. ");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            Console.ReadLine();

        }
    }
}
