using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremod é {numero}");

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} é o número que queremos? ");
                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                    // essa utilização do "break" é util para situações nas quais o loop deve ser interompido assim que o resultado esperado for atingido.
                    // Sem o "break" o loop continuaria até o fim dos dados.
                } else {
                    Console.WriteLine("Nao");
                }
            }
        }
    }
}
