using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Password {
    internal class Program {
        static void Main(string[] args) {
            int password;

            Console.WriteLine("Digite a senha: ");
            password = int.Parse(Console.ReadLine());

            while(password != 2002) {
                Console.WriteLine("Senha inválida!");
                Console.WriteLine("Digite a senha novamente: ");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");

            Console.ReadKey();
        }
    }
}
