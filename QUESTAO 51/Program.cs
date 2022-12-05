using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QtdAlunos, NotasP = 0;
            bool NotasR = true;

            Console.WriteLine("Digite a quantidade de alunos: ");
            QtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] notas = new int[QtdAlunos];

            for (int x = 0; x< QtdAlunos; x++)
            {
                Console.WriteLine($"Digite a nota do {x+1} º Aluno: ");
                notas[x] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (notas[x] > 7)
                {
                    NotasP++;
                }
                if (notas[x] >5)
                {
                    NotasR = false;
                }
            }
            if (NotasR == false)
            {
                Console.WriteLine($"Existem {NotasP} notas maiores que 7. ");
            }
            else
            {
                Console.WriteLine("Não existe nenhum aluno com nota acima de 5. ");
            }
            Console.ReadLine();
        }
    }
}
