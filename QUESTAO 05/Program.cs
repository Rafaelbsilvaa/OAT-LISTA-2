using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double VelocidadeMedia, TempoGasto, Autonomia = 12;
            double Distancia, LitrosUsados;

            Console.WriteLine("Quantidade de litros de combustível gato em uma viagem");

            Console.WriteLine("Digite o tempo que você gastou em sua viagem (horas): ");
            TempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a velocidade Média em que voce fez o percurso (km/h)");
            VelocidadeMedia= double.Parse(Console.ReadLine());

            Distancia = VelocidadeMedia * TempoGasto;
            LitrosUsados = Distancia / Autonomia;

            Console.WriteLine("Resultados");
            Console.WriteLine("Velocidade Média =" + VelocidadeMedia + "Km/h");
            Console.WriteLine("Tempo gasto = " + TempoGasto + "horas ");
            Console.WriteLine("Distancia Percorrida = " + Distancia + "Km ");
            Console.WriteLine("Quantidade de Combustível utilizado: " + LitrosUsados + "litros");
            Console.ReadLine();
        }
    }
}
