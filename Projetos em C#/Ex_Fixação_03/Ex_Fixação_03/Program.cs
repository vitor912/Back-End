using System;

namespace Ex_Fixação_03 {
    internal class Program {
        static void Main(string[] args) {


            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, Total1;

            Console.WriteLine("Digite o codigo do produto, quantidade e valor");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2]);

            Console.WriteLine("Digite o codigo do segundo produto, quantidade e valor");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2]);

            Total1 = preco1 * qte1 + preco2 * qte2;


            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", Total1);

        }
    }
}
