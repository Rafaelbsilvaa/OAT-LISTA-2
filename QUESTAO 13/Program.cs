using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Digite o 1° valor: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° valor: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3° valor: ");
            C = int.Parse(Console.ReadLine());

            if(A > C)
            {
                int aux = C;
                C = A;
                A = aux;
            }
            if (A > B)
            {
                int aux = B;
                B = A;
                A = aux;
            }
            if (B > C)
            {
                int aux = C;
                C = B;
                B = aux;
            }

            Console.WriteLine("Os números insiridos são: " +A, +B, +C);
            Console.ReadLine();

            
        }   
       
    }
}
