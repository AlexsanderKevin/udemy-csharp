using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "kevin";
            // nome = 123  -> isso resultaria em um erro, uma vez que a inferencia definiu que a variavel "nome" será do tipo string

            // var idade;  o valor deve ser inserido no momento da declaração para que o compilador entenda de que tipo é o valor

            int a; // declaração de variável
            int b = 2; // inicialização de variável
        }
    }
}
