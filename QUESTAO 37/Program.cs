using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string charOpcao;
            bool encerrar = false;
            int num1 = 0, num2 = 0;

            while (encerrar == false)
            {
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine(" 1 - Adição");
                Console.WriteLine(" 2 - Subtração");
                Console.WriteLine(" 3 - Multiplicação");
                Console.WriteLine(" 4 - Divisão ");

                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                num2= int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado de {num1} + {num2} = {num1 + num2}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado de {num1} - {num2} = {num1 - num2} ");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado de { num1} x {num2} = {num1 * num2} ");
                        break;
                    case 4:
                        Console.WriteLine($"Resultado de {num1} / {num2} = {num1/num2}");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, digite novamente a opção:");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Deseja continuar? (s/n) ");
                charOpcao = Console.ReadLine();
                if (string.ReferenceEquals(charOpcao, "N") || string.ReferenceEquals(charOpcao, "n"))
                {
                    encerrar = true;
                    
                }
                Console.ReadLine();
            }

        }
    }
}
