using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 0;
            double Bbase = 0;


            Console.WriteLine("Digite o tamanho da base: ");
            Bbase = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho da altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A hipotenusa é:" + Hipotenusa(Bbase, altura));
            Console.ReadLine();
        }
            public static double Hipotenusa(double Bbase, double altura)
            {
                double hipotenusa = ((Bbase * Bbase)+ (altura * altura));
                hipotenusa = Math.Sqrt(hipotenusa);
                return hipotenusa;
            }

        
    }
}
