using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, maior, menor;

            Console.WriteLine("Digite um número positivo: ");
            num = int.Parse(Console.ReadLine());
            
            if (num >= 0)
            {
                menor = num;
                maior = num;
                while ( num >=0)
                {
                    Console.WriteLine("Digite outro número: (para finalizar digite um númeor negativo)");
                    num = int.Parse(Console.ReadLine());
                    if ( num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor && num >= 0)
                    {
                        menor = num;
                    }

                }Console.WriteLine($"O maior número foi {maior} e o menor foi {menor}");
                Console.ReadLine();
            }
        }
    }
}
