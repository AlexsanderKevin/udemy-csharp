using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            Console.WriteLine("Operadores Relacionais");

            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;
            Console.WriteLine($"Nota: {nota}");
            Console.WriteLine($"Nota de Corte: {notaDeCorte}");

            Console.WriteLine($"Nota inválida? {nota < 0 || nota > 10}");
            Console.WriteLine($"Perfeito? {nota == 10}");
            Console.WriteLine($"Tem como melhorar? {nota < 10}");
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");
        }
    }
}
