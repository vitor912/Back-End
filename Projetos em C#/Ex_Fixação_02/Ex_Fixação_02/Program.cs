using System;
using System.Globalization;

namespace Ex_Fixação_02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre com sua idade:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com sua altura:");
            double h1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Entre com  o seu peso:");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Qual é o seu sexo (M) Masculino (F) Feminino");
            char sex = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Me diga uma cor, altura e comprimento");
            string[] vs = Console.ReadLine().Split(' ');
            string color = vs[0];
            double h2 = double.Parse (vs[1], CultureInfo.InvariantCulture);
            double length = double.Parse (vs[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Seus dados são");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(h1.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(weight.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(sex);
            Console.WriteLine(color);
            Console.WriteLine(h2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(length.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
