using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, Resultado;
            int menu;
            Console.WriteLine(" CALCULADORA");
            while (true)
            {


               
                

                Console.WriteLine("Digite o primeiro número: ");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                num2 = float.Parse(Console.ReadLine());

             
                Console.WriteLine("Digite uma das operações a seguir: Adição +, Subtração -, Multiplicação *, Divisão / ");
                Console.WriteLine();
                Console.WriteLine("[1] para Adição");
                Console.WriteLine("[2] para Subtração");
                Console.WriteLine("[3] para Multiplicação");
                Console.WriteLine("[4] para Divisão");

                menu = int.Parse(Console.ReadLine());

                if ( menu == 1)
                {
                    Resultado = num1+ num2;
                    Console.WriteLine("O resultado é: "+Resultado);
                }
                if ( menu == 2)
                {
                    Resultado = num1 - num2;
                    Console.WriteLine("O resultado é: " + Resultado);
                }
                if ( menu == 3)
                {
                    Resultado = num1 * num2;
                    Console.WriteLine("O resultado é: " +Resultado);
                }
                if ( menu == 4)
                {
                    Resultado = num1 / num2;
                    Console.WriteLine("O resultado é: " +Resultado);
                }
                Console.WriteLine();
                Console.WriteLine("Digite S para sair ou qualquer coisa para continuar");
                if (Console.ReadLine().Equals("S")) break;
            } 

           
        }   
    }
}
