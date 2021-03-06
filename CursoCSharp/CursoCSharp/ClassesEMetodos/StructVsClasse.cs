using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR, gera uma Cópia e não uma referencia
            ponto1.X = 3;

            Console.WriteLine($"ponto 1 X = {ponto1.X}");
            Console.WriteLine($"copia Ponto 1 X = {copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por REFERENCIA.
            ponto2.X = 7;

            Console.WriteLine($"ponto 2 X = {ponto2.X}");
            Console.WriteLine($"copia ponto 2 X = {copiaPonto2.X}");
        }
    }
}
