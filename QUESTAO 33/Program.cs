using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QtdAlunos;
            string matricula;
            double media = 0;

            Console.WriteLine("Digite a quantidade de alunos: ");
            QtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] aluno = new int[QtdAlunos];

            for (int x = 0; x <QtdAlunos; x++)
            {
                Console.WriteLine("Digite o número da matrícula do aluno: ");
                matricula = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                double nota = int.Parse(Console.ReadLine());
                Console.WriteLine();
                media += nota;
            }
            Console.WriteLine($"A média da turma foi de {string.Format("{0:C1}", (media /QtdAlunos))}");
            Console.ReadLine();
        }
    }
}
