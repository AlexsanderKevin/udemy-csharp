using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            Produto p1 = new Produto("Caneta", 1.8);
            Produto p2 = new Produto("Canela", 1.8);
            Produto p3 = p2; // Referencia;

            Console.WriteLine(p1 == p2); // False - porque estão sendo comparadas as referencias de cada um na memoria;
            Console.WriteLine(p2 == p3); // True

            Console.WriteLine(p1.Equals(p2)); // False - ainda se está comparando os locais na memória;
        }
    }
}
