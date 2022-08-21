internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o primeiro lado: ");
        double l1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo lado: ");
        double l2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro lado: ");
        double l3 = double.Parse(Console.ReadLine());

        bool tri = (l1 < l2 + l3) && (l2 < l1 + l3) && (l3 < l1 + l2);
        bool eq = (l1 == l2) && (l2 == l3);
        bool es = (l1 != l2) && (l2 != l3) && (l1 != l3);
        Console.WriteLine();
        Console.WriteLine("Pode formar um TRIANGULO? " + tri);
        Console.WriteLine("O triangulo é EQUILATERO? " + eq);
        Console.WriteLine("O triangulo é ESCALENO? " + es);
    }
}