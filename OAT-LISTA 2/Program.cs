internal class Program
{
    public static object entrada { get; private set; }

    public static void Main(string[] args)
    { entrada = new {
    };
        double quantidade_minima;
        double quantidade_maxima;
        double estoque_medio;

        estoque_medio = double.MaxValue;


        Console.WriteLine("Calculadora de Estoque Medio");
        Console.WriteLine("Digite a quantidade mínima:");
        


        Console.WriteLine("Digite a quantidade maxima:");
        

        Console.WriteLine("Estoque Médio =" + estoque_medio +"g");
        Console.ReadLine();
    }
}