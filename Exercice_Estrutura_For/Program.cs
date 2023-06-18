using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Estrutura_For {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor para x entre 1 e 1000: ");
            int x = int.Parse(Console.ReadLine());   

            for(int i = 0; x <= 0 || x > 1000; i++) {
                Console.WriteLine("Digite um valor válido para x: ");
                x= int.Parse(Console.ReadLine());
                i--;
            }

            for (int i = 1; i < x; i++) {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
