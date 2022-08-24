internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual o valor do empréstimo? ");
        double emp = double.Parse(Console.ReadLine());

        double por = emp * 0.20;
        double valor = por + emp;

        Console.Write("Quantas parcelas? ");
        double parcelas = double.Parse(Console.ReadLine());

        double resultado = valor / parcelas;
        Console.WriteLine($"Vou pagar {parcelas} parcelas de R${resultado} reais");
    }
}