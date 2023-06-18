using System;
using System.Globalization;

namespace Estrutura_For_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de divisões: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um valor para o numerador: ");
                int numerador = int.Parse(Console.ReadLine());

                Console.Write("Digite um valor para o denominador: ");
                int denominador = int.Parse(Console.ReadLine());

                if(denominador == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else
                {
                    double resultado = (double)numerador / denominador;
                    Console.WriteLine("O resultado da divisão é igual a: " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();

        }
    }
}
