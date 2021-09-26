using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, i, t, j, m;
            Console.WriteLine("\n--Juros Simples--\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Para calcular o juros simples, Digite:\n");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Capital (R$).....: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.ResetColor();
            Console.Write("Taxa de juros (%): ");
            i = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Tempo (Meses)....: ");
            t = Convert.ToDouble(Console.ReadLine());

            j = c * (i / 100) * t;

            m = c + j;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nE o resultado é");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nJuros...: {j:C}");
            
            Console.ResetColor();
            Console.WriteLine($"Montante: {m:C}\n");
        }
    }
}
