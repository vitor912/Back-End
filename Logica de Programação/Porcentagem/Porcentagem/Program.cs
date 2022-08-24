using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual o valor do empréstimo? ");
        double emp = double.Parse(Console.ReadLine());

        Console.Write("Quantas parcelas? ");
        double parcelas = double.Parse(Console.ReadLine());


        if (parcelas <= 4)
        {
            double porc = emp * 0.08;
            double valorPorc = emp + porc;
            double resultado = valorPorc / parcelas;
            Console.WriteLine($"Vou pagar {parcelas} parcelas de R${resultado.ToString("F2", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine("O total de prestações á pagar: R$" + valorPorc.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
        else if (parcelas <= 10)
        {
            double porc = emp * 0.15;
            double valorPorc = emp + porc;
            double resultado = valorPorc / parcelas;
            Console.WriteLine($"Vou pagar {parcelas} parcelas de R${resultado.ToString("F2", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine("O total de prestações á pagar: R$" + valorPorc.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
        else if (parcelas <= 18)
        {
            double porc = emp * 0.20;
            double valorPorc = emp + porc;
            double resultado = valorPorc / parcelas;
            Console.WriteLine($"Vou pagar {parcelas} parcelas de R${resultado.ToString("F2", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine("O total de prestações á pagar: R$" + valorPorc.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
        else
        {
            Console.WriteLine("Parcelamentos até 18x");
        }
    }
}