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


            
        }
    }
}
