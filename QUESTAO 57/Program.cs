using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, Vogais = "aeiouAEIOU", StringVogais = "";

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] ArrayChars = frase.ToCharArray();

            for (int x= 0; x< ArrayChars.Length; x++)
            {

                if(Vogais.Contains("" + ArrayChars[x]))
                {
                    StringVogais+= ArrayChars[x];
                }
            }
            Console.WriteLine("Nova frase: " + StringVogais);
            Console.ReadLine();
        }
    }
}
