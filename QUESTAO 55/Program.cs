using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frases;
            string Novafrase = "";

            do
            {
                Console.WriteLine("Digite um frase (limite de 50 caracteres): ");
                frases = Console.ReadLine();
            } while (frases.Length > 50);

            char[] ArrayChars = frases.ToCharArray();

            for (int x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != ' ')
                {
                    Novafrase = Novafrase + ArrayChars[x];
                }
            }
            Console.WriteLine($"Nova frase: {Novafrase}");
            Console.ReadLine();
        }
    }
}
