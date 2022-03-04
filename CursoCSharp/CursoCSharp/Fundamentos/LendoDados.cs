using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Lendo Dados:");

            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine(); // Todo valor lido será uma string, mesmo se for digitado um número.

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário: ");
            double salario = double.Parse(Console.ReadLine(), // essa não é a forma mais segura de se fazer o "Parse"
                CultureInfo.InvariantCulture);

            Console.WriteLine($"nome: {nome}, idade: {idade}, salario: R${salario}.");
        }
    }
}
