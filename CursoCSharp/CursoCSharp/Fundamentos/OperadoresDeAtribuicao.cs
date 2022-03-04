using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresDeAtribuicao {
        public static void Executar() {
            Console.WriteLine("Operadores de Atribuição: ");

            var num1 = 3; // num1 recebe o valor 3
            num1 = 7; // num1 descarta seu valor anterior e recebe 7 
            num1 += 10; // num1 recebe o proprio valor (7) somado a 10 // num1 = num1 + 10
            num1 -= 7; // num1 recebe o proprio valor (17) subtraido 7 // num1 = num1 - 7
            num1 *= 5; // num1 recebe o proprio valor (10) multiplicado por 5 // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2
            Console.WriteLine($"Numero: {num1}");

            int a = 1;
            int b = a; // aqui é feita uma copia independente da variavel "a"

            a++; // a = a + 1
            b--; // b = b - 1
            Console.WriteLine($"{a}, {b}");
        }
    }
}
