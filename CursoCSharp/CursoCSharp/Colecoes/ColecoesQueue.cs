using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            Queue<string> fila = new Queue<string> ();
            fila.Enqueue("Fulano"); // Enqueue é a maneira de inserir dados na Queue;
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano"); // Queue aceita repetição;

            string primeiroDaFila = fila.Peek(); // Peek seleciona o primeiro item de uma fila, mas NÃO remove o item;
            Console.WriteLine($"Primeiro: {primeiroDaFila}");

            fila.Dequeue(); // Dequeue remove o primeiro membro da fila;
            
            foreach(string membro in fila) {
                Console.WriteLine(membro);
            }

            var salada = new Queue();
            salada.Enqueue("Alface");
            salada.Enqueue(23);
            salada.Enqueue(true);

            Console.WriteLine("Salada..");
            foreach(var item in salada) {
                Console.WriteLine(item);
            }

            bool contem = salada.Contains("Alface");

            Console.WriteLine($"Salada tem alface? {contem}");
        }
    }
}
