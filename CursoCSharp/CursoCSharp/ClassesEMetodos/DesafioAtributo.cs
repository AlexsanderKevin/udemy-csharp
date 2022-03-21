using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;
        // 'a' é um atributo de instancia, ou seja, pertence apenas às instancias criadas a partir da classe
        public static void Executar() {
            // Acessar a variavel 'a' dentro do métodos Executar!
            var classe = new DesafioAtributo();
            Console.WriteLine(classe.a);
        }
    }
}
