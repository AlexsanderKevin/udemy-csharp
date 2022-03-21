using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        // A palavra "static" indica que o método ou atributo em questão pertence à classe, e não à instancia da classe

        // Método de instancia
        public int Somar(int a, int b) {
            return a + b;
        }

        // Método de classe (estatico)
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 4));
        }
    }
}
