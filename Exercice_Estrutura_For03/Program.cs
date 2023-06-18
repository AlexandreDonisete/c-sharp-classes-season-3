using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Estrutura_For03 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor para n: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Digite o valor da primeira nota: ");
                double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o valor da segunda nota: ");
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o valor da terceira nota: ");
                double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double nFinal = (n1 * 2 + n2 * 2 + n3 * 5) / 10;

                Console.WriteLine(" ");

                Console.WriteLine("Nota final: " + nFinal.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine(" ");
            }
                
            Console.ReadKey();
        }
    }
}
