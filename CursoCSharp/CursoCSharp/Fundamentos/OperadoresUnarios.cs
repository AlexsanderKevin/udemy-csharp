using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            Console.WriteLine("Operadores Unarios");

            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // o "-" inverte o sinal do valor alvo
            Console.WriteLine(!booleano); // "!" indiva o valor oposto do valor alvo

            numero1++; // incrementa 1 ao valor "numero1" // operador pós fixado
            Console.WriteLine(numero1);

            --numero1; // operador pré fixado -> faz quase a mesma coisa do operador pós fixado
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            // o numero2, por estar com operador pré fixado, será decrementado antes da comparação
            // já o numero1, por estar com o operador pós fixado, será incrementado depois da comparação
            Console.WriteLine($"{numero1} - {numero2}");
        }
    }
}
