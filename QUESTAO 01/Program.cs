using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade_minima;
            int quantidade_maxima;
            int estoque_medio;

            


            Console.WriteLine("Calculadora de Estoque Medio");
            Console.WriteLine("Digite a quantidade mínima:");
            quantidade_minima = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite a quantidade maxima:");
            quantidade_maxima= int.Parse(Console.ReadLine());

            estoque_medio = (quantidade_minima + quantidade_maxima) / 2;
            Console.WriteLine("Estoque Médio =" + estoque_medio);
            Console.ReadLine();
        }
    }
}
