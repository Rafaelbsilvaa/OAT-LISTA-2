﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario atual: ");
            double SalarioAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de reajuste: ");
            double valor = (double.Parse(Console.ReadLine()) / 100);
            Console.WriteLine("O novo salario é de R$" + ( Reajuste(SalarioAtual, valor))+  ".");
            Console.ReadLine();
        }

        public static double Reajuste(double Salario, double IndiceReajuste)
        {
            double NovoSalario = Salario + (Salario * IndiceReajuste);
            return NovoSalario;
        }

    }
    
}
