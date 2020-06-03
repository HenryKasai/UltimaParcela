using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vlrtotal;
            int parcelas;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("Insira o valor total a ser pago.");
            vlrtotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira a quantidade total de parcelas mensais (sem juros)");
            parcelas = Convert.ToInt32(Console.ReadLine());

            decimal vlrparcela = vlrtotal / parcelas;
            DateTime agora = DateTime.Now;
            DateTime final = agora.AddMonths(parcelas);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sua última parcela será em {final.ToShortDateString()}, no valor de R${vlrparcela:N2}.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
