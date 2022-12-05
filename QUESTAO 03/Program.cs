using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pagamento de comssão de venda ");

            int IdVendedor, IdPeca;
            float PrecoPeca, Quatidade, ValorComissao, PorcentagemComissao = 0.5f;

            Console.WriteLine("Digite a identificação do vendedor: ");
            IdVendedor= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID da Peça: ");
            IdPeca= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário da peça: ");
            PrecoPeca= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            Quatidade= float.Parse(Console.ReadLine());

            ValorComissao = (PrecoPeca * Quatidade) * PorcentagemComissao;

            Console.WriteLine("O valor da comissão é de reais 0" + ValorComissao);
            Console.ReadLine();

        }   

    }
}
