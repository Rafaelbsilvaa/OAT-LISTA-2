using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5], B = new int[8];
            IList<int> C = new List<int>();
            int W = 0, aux = 1;

            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine($"Digite um {aux++} ª número para o vetor B: ");
                B[x] = int.Parse( Console.ReadLine() );
                for ( int y = 0; y < 5; y++)
                {
                    if (B[x] == A[y])
                    {
                        C.Insert(W, B[x]);
                        W++;
                    }
                }
            }
            Console.WriteLine("Númeors comuns: ");
            for(int x= 0; x < C.Count; x++)
            {
                Console.WriteLine(C[x] +" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
