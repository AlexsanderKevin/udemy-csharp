using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ColecaoStack {
        public static void Executar() {
            // a Stack (pilha) funciona com LIFO, ao contrario da fila, que usa FIFO;
            Stack pilha = new Stack();
            pilha.Push(3);
            pilha.Push('a');
            pilha.Push("ha");
            pilha.Push(true);

            //foreach(var item in pilha) {
            //    Console.WriteLine(item);
            //}

            void ShowAllItems(dynamic collection) {
                foreach(var item in collection) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }

            ShowAllItems(pilha);

            var popPilha = pilha.Pop(); // retorna e REMOVE o item do topo;
            Console.WriteLine($"pop: {popPilha}\n");
            ShowAllItems(pilha);

            var peekPilha = pilha.Peek(); // retorna mas NÃO remove o item do topo;
            Console.WriteLine($"peek: {peekPilha}\n");
            ShowAllItems(pilha);
        }
    }
}
