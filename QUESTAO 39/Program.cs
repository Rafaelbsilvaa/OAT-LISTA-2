using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool Encerrou = false;
            char escolha;

            do
            {
                Console.WriteLine("Digite um valor: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O número é par: ");

                }
                else
                {
                    Console.WriteLine("O número é impar: ");
                }
                if (num < 0)
                {
                    Console.WriteLine("O número é negativo");

                }
                else
                {
                    Console.WriteLine("O número é positivo ");
                }
                Console.WriteLine();
                Console.WriteLine("Deseja sair? (s/n)");
                escolha = char.Parse(Console.ReadLine());
                if (escolha == 's'|| escolha =='S')
                {
                    Encerrou = true;
                }
                 
                   
                
            } while (Encerrou == false);
        }
    }
}
