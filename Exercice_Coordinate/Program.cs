using System;

namespace Exercice_Coordinate {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor para x e y: ");
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            while(x != 0 && y != 0) {
                if(x > 0 && y > 0)
                    Console.WriteLine("Primeiro");

                else if(x < 0 && y > 0)
                    Console.WriteLine("Segundo");

                else if(x < 0 && y < 0)
                    Console.WriteLine("Terceiro");

                else
                    Console.WriteLine("Quarto");

                Console.WriteLine("Digite novos valores para x e y: ");
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }

            Console.WriteLine("Fim!");
            Console.ReadKey();
        }
    }
}
