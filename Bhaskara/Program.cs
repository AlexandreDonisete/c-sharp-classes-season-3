using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Digite um valor para a variável a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a variável b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a variável c: ");
            c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O valor do delta da equação é igual a: " + delta);
            Console.WriteLine("O valor da primeira raiz da equação é igual a: " + x1);
            Console.WriteLine("O valor da segunda raiz da equação é igual a: " + x2);

            Console.ReadKey();
        }
    }
}
