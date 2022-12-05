using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            bool Encerrar = false;
            char opcao;

            do
            {
                do
                {
                    Console.WriteLine("Digite o ídice de poluição (utilize a ',' Exe: 0,1): ");
                    num = double.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        Console.WriteLine("Número inválido! ");
                    }
                } while (num < 0);

                Console.WriteLine();

                if (num >= 0 && num <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }

                if (num >= 0.3)
                {
                    Console.WriteLine("Suspender as atividades das industrias do Grupo 1!");

                }
                if( num >= 0.4)
                {
                    Console.WriteLine("Suspender as atividades das industrias do Grupo 2!");
                }
                if (num >= 0.5)
                {
                    Console.WriteLine("Suspender as atividades das industrias do Grupo 3!");
                }
                Console.WriteLine("Deseja encerra o program? (s/n) ");
                opcao = char.Parse(Console.ReadLine());

                if(opcao == 's' || opcao =='S')
                {
                    Encerrar= true;
                }

            }while(Encerrar == false);
        }
    }
}
