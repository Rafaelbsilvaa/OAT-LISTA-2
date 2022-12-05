using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit;

            Console.WriteLine("Conversor de Temperatura: ");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            Celsius = (Fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A medida convertida para Celsius é: " + Celsius + "°");

            Console.ReadLine();
        }
    }
}
