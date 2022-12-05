using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Lado dos triângulo");

            Console.WriteLine("Digite a lado A= ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B= ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C= ");
            C = int.Parse(Console.ReadLine());

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é Equilatero.");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O triângulo é Isósceles. ");
                }
                else
                {
                    Console.WriteLine("Esse é um triângulo escaleno.");
                }
            }
                else
            {
                Console.WriteLine("Os dados inseridos não se caracterizam com um triangulo");
            }
            Console.ReadLine();
        }   
    }
}
