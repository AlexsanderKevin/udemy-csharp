using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero += 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0; // na utilização do "out" a variavel deve ser inicializada de qualquer jeito.
            numero += 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine("a = " + a);

            // int b = 2;
            AlterarOut(out int b); // é possivel inicializar a variavel ja dentro dos parametros
            Console.WriteLine("b = " + b);
        }
    }
}
