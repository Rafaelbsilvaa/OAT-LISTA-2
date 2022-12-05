using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool Encerrar = false;
            char opcao;
            string categoria;

            do
            {
                do
                {
                    Console.WriteLine("Digite a sua idade: ");
                    idade = int.Parse(Console.ReadLine());

                    if (idade < 5)
                    {
                        Console.WriteLine("Você não tem idade suficiente! ");
                        Console.WriteLine();
                    }
                } while (idade < 5);

                Console.WriteLine();

                if (idade >= 5 && idade < 8)
                {
                    categoria = "Infantil A";
                }
                else if (idade >= 8 && idade < 12)
                {
                    categoria = "Infantil B";
                }
                else if (idade >= 12 && idade< 14)
                {
                    categoria = "Juvenil A";
                }
                else if (idade >= 14 && idade <18)
                {
                    categoria = "Juvenil B";
                }
                else
                {
                    categoria = "Adultos";
                }
                Console.WriteLine("Sua categoria é: " +categoria);

                Console.WriteLine("Deseja enceerrar o programa? (s/n)");
                opcao = char.Parse(Console.ReadLine());
                if (opcao == 'S' || opcao == 'S')
                {
                    Encerrar = true;
                }
            }while(Encerrar == false);
        }
    }
}
