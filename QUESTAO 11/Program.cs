using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, Variavel;

            Console.WriteLine("Efetuador de troca de valores entre variaveis");

            Console.WriteLine("Digite a variável A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a variável B: ");
            B = int.Parse(Console.ReadLine());

            Variavel = A;

            A= B;
            B= Variavel;

            Console.WriteLine("A= " +A);
            Console.WriteLine("B= " + B);
            Console.ReadLine();
        }
    }
}
