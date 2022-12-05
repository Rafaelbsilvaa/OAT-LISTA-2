using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double altura;
            double peso = 00.0;

            Console.WriteLine("Insira seu sexo: ");
            Console.WriteLine("Onde 'F' é feminino // e 'M' masculino");
            sexo = Console.ReadLine();

            Console.WriteLine("Utilize ',' exemplo: 1,80");
            Console.WriteLine();
            Console.WriteLine("Insira sua Altura: ");
            altura = double.Parse(Console.ReadLine());

            if (sexo == "F")
            {
                peso = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é: {string.Format("{0:C2}", (peso))}");
            }
            if (sexo == "M")
            {
                peso = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é: {string.Format("{0:C2}", (peso))}");
            }
            Console.ReadLine();
        }
    }
}
