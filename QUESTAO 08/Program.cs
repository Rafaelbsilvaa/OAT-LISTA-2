using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Raio, Altura, Volume;

            Console.WriteLine("Calculo de volume Óleo");

            Console.WriteLine("Digite diâmentro da lata (em cm): ");
            Raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata (em cm): ");
            Altura = double.Parse(Console.ReadLine());

            Volume = Math.PI * Raio* Raio * Altura;

            Console.WriteLine(" O Voleume da lata é de " + Volume );
            Console.ReadKey();
        }
    }
}
