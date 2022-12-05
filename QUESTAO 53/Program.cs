using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QUESTAO_53
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int Nvoltas, total = 0, media, Mtempo = 0, Mvolta = 0;

            Console.WriteLine("Digite o numero de voltas: ");
            Nvoltas = int.Parse(Console.ReadLine());

            int[] tempos = new int[Nvoltas];
            for ( int x = 0; x < Nvoltas; x++ )
            {
                Console.WriteLine($"Digite o tempo da {x+1}ª volta (em segundos): ");
                tempos[x] = int.Parse(Console.ReadLine());
                total += tempos[x];
                if (tempos[x] < Mtempo || x== 0)
                {
                    Mtempo = tempos[x];
                    Mvolta = x + 1;
                }

            }
            media = total / Nvoltas;

            Console.WriteLine($"i. O melhor tempo foi: {Mtempo} segundos.");
            Console.WriteLine($"ii. Melhor volta foi: {Mvolta}ª ");
            Console.WriteLine($"iii. A média de tempo foi: {media}");

            Console.ReadLine();
        }
        
    }
}
