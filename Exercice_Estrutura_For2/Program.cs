using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Estrutura_For2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um valor para n: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite um número: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                    dentro++;
                else
                    fora++;
            };

            Console.WriteLine(dentro + " In");
            Console.WriteLine(fora + " Out");

            Console.ReadKey();
        }
    }
}
