﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit;

            Console.WriteLine("Conversor de temperatura: ");

            Console.WriteLine("Digite a temperatura em Celsius: ");
            Celsius=double.Parse(Console.ReadLine());

            Fahrenheit = (9 * Celsius + 160) / 5;

            Console.WriteLine("A medida convertida é " + Fahrenheit + "º");

            Console.ReadLine();
        }
    }
}
