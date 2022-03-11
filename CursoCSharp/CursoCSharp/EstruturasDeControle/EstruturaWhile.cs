using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); // nesse caso o número 16 não vai entrar nas possibilidades
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Tente advinhar o numero de 1 a 15: ");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativasRestantes--;
                tentativas++;

                if (palpite == numeroSecreto) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Acertou em {tentativas} tentativas! O número é: {numeroSecreto}");
                    Console.BackgroundColor = corAnterior;
                } else if (numeroSecreto > palpite) {
                    Console.WriteLine($"Errou, tente um número maior! Tentativas: {tentativas}");
                } else {
                    Console.WriteLine($"Errou, tente um número menor! Tentativas: {tentativas}");
                }
            }
        }
    }
}
