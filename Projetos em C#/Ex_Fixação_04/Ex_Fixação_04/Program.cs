using System;
using System.Globalization;

namespace Ex_Fixação_04 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).");
            Console.WriteLine();
            Console.WriteLine("Se o ponto estiver na origem, escreva a mensagem “Origem”.");
            Console.WriteLine();
            Console.WriteLine("Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.");
            Console.WriteLine();
            Console.WriteLine("Digite o valor de X e depois de Y.");

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }

            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }

            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }

            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Quadrante 1");
            }

            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Quadrante 2");
            }

            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Quadrante 3");
            }

            else {
                Console.WriteLine("Quadrante 4");
            }

        }
    }
}
