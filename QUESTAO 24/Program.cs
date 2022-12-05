using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int opcao = 0;
            while (true)
            {
                Console.WriteLine("Insira um valor: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira um segundo valor: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine();
                Console.WriteLine("1 - Verificar se um dos números lidos é ou não multiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7.");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Os números insiridos são multiplos!");
                    }
                    else
                    {
                        Console.WriteLine("Os números insiridos não são multiplos!");
                    }
                }
                if (opcao == 2)
                {
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Ambos números são pares!");
                    }
                    else
                    {
                        Console.WriteLine("Os dois números não são pares!");
                    }
                }
                if ( opcao== 3)
                {
                    if ((num1 + num2)/2 >7)
                    {
                        Console.WriteLine("A media dos números é maior que 7!");
                    }
                    else
                    {
                        Console.WriteLine("A media dos números é menor que 7!");
                    }
                }
                if (opcao == 4) break;
            }
        }
    }
}
