using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            bool acertou = false;
            int chute, Qtdtentativas = 0;

            int numero = gerador.Next(101);

            while (acertou == false)
            {
                Console.WriteLine("Digite um número entre 0 a 100: ");
                chute = int.Parse(Console.ReadLine());
                Qtdtentativas++;
                if (chute == numero)
                {
                    Console.WriteLine($"Você acertou em {Qtdtentativas} tentativas! ");
                    acertou = true;
                }
                else if( chute > numero)
                {
                    Console.WriteLine("O número é menor. ");
                }
                else
                {
                    Console.WriteLine("O número é maior.");
                }
                Console.ReadLine();
            }
        }
    }
}
