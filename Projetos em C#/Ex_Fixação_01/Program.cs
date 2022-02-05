using System;
using System.Globalization;

namespace Ex_Fixação_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            string nome1 = "Vitor";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.00;
            double media = 53.234567;

            double total = preco1 + preco2;

            Console.WriteLine("Produto");
            Console.WriteLine("{0}, cujo o valor é ${1:F2} reais", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo o valor é ${preco2:F2} reais");
            Console.WriteLine("Total de $" + total.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine();
            Console.WriteLine("Código do Registro: {0}", codigo);
            Console.Write(nome1 + " tem " + idade + " anos de idade, ");
            Console.WriteLine("gênero: {0}.", genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", media);
            Console.WriteLine("Arredondado (Três casas decimais): {0:F3}", media);
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("FIM");

        }
    }
}
