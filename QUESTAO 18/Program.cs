using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Codigo;

            Console.WriteLine("Verificador de código ");

            Console.WriteLine("Digite o código:");
            Codigo = int.Parse(Console.ReadLine());

            switch(Codigo) {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois"); 
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido: " +Codigo);
                    break;
            }
            Console.ReadLine();

        }
    }
}
