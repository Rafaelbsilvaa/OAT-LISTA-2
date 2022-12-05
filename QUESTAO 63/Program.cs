using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Verifica(numero));
            Console.ReadLine();
        }

        public static String Verifica(int num)
        { 
                if(num %2 == 0)
                {
                    return "PAR";
                }
                else
                {
                    return "iMPAR";
                }
                Console.WriteLine($"O numero é ");
                Console.ReadLine();
            
        }
    }
}
