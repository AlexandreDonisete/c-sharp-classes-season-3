using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Fuel {
    internal class Program {
        static void Main(string[] args) {
            int alcool = 0, gasolina = 0, diesel = 0, code = 0;
            
            Console.WriteLine("Digite 1 para alcool, 2 para gasolina, 3 para diesel e 4 para finalizar: ");
            code = int.Parse(Console.ReadLine());

            while(code !=4) {
                if (code == 1)
                    alcool++;

                else if (code == 2) 
                    gasolina++;

                else if (code == 3)
                    diesel++;

                else 
                    Console.WriteLine("Digite um código válido! ");
                
                Console.WriteLine("Digite 1 para alcool, 2 para gasolina, 3 para diesel e 4 para finalizar: ");
                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            Console.ReadKey();
        }
    }
}
