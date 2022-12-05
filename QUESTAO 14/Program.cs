using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, Diferenca;

            Console.WriteLine("Verificado de número");

            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 >=num2)
            {
                Diferenca = num1 - num2;
            }
            else
            {
                Diferenca = num2 - num1;
            }
            Console.WriteLine("A diferença do maior para o menor é " + Diferenca);
            Console.ReadLine();
        }
    }
}
