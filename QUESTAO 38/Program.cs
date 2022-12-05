using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C;
            double N, E = 0, VHora, Excedente;
            bool continuar = true;
            char texto;

            do
            {
                E = 0;
                VHora = 10;
                Excedente = VHora * 2;

                Console.WriteLine("Digite o código do operário: ");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de horas trabalhadas: ");
                N = double.Parse(Console.ReadLine());

                if (N > 50)
                {
                    E = N - 50;
                }

                Console.WriteLine($"{C} Salario: {N * VHora} Salario excedente: {E * Excedente} Salario total: {E * Excedente + N * VHora}");

                Console.WriteLine("Deseja encerrar o programa? (s/n) ");
                texto = char.Parse(Console.ReadLine());

                if (texto == 's' || texto == 'S')
                {
                    continuar = false;
                }
            } while (continuar);
        }
    }
}
