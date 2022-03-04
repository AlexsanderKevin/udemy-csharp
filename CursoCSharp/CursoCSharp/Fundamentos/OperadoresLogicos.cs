using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            Console.WriteLine("Operadores Lógicos");

            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 32? {comprouTv32}");
            Console.WriteLine($"Mais saudavel? {!comprouSorvete}");

            // Operadores Binários vs Unários
            // Binários: Operam diante de dois valores, tal como a soma, subtração, igualdade, etc
            // Unários: Operam em cima de apenas um valor, como é o caso da negação, que apenas inverte um determinado valor.
        }
    }
}
