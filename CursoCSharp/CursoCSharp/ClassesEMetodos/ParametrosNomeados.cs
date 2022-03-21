using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }
        public static void Executar() {
            Formatar(mes: 3, dia: 9, ano: 2002);
        }
    }
}
