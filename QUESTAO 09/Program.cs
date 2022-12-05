using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anos, Meses, Dias, total;

            Console.WriteLine("Calculadora de idade");

            Console.WriteLine("Digite os anos:");
            Anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os meses: ");
            Meses= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dias: ");
            Dias= int.Parse(Console.ReadLine());

            total = Anos * 365 + Meses * 30 + Dias ;
            Console.WriteLine("Idade total em dias = " + total);

            Console.ReadLine();

        }
    }
}
