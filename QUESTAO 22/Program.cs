using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, numero;

            Console.WriteLine("Organizador");

            
            {
                Console.WriteLine("Digite um número");
                
                numero = int.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    A = numero;
                    Console.WriteLine("Numero armazenado em A ");
                }else
                {
                    B = numero;
                    Console.WriteLine("Número armazenado em B");
                }
            }
            Console.WriteLine("A=" + A + "B=" + B);
            Console.ReadLine();
        }
    }
}
