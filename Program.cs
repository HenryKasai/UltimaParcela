using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira o valor total a ser pago.");
            
            string vlrtotal = Console.ReadLine();
            decimal vlrtotaldecimal = Convert.ToDecimal(vlrtotal);

            Console.WriteLine("Insira a quantidade total de parcelas mensais (sem juros)");

            string parcelas = Console.ReadLine();
            int parcelasint = Convert.ToInt32(parcelas);
            decimal vlrparcela = vlrtotaldecimal / parcelasint;
            DateTime agora = DateTime.Now;
            DateTime final = agora.AddMonths(parcelasint);
            string finalstring = Convert.ToString(final);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sua última parcela será em {final.ToShortDateString()}, no valor de R${vlrparcela:N2}.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
