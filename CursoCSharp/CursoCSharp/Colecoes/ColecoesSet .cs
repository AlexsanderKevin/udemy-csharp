using System;
using System.Collections.Generic; // Este import é necessário para este conteudo
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            Produto livro = new Produto(nome: "Game of Thrones", preco: 49.9);
            
            // HashSet NÃO é uma estrutura indexada;
            HashSet <Produto> carrinho = new HashSet <Produto>();

            HashSet <Produto> combo = new HashSet <Produto> {
                new Produto("Camisa", 59.9),
                new Produto("Calça", 99.9),
                new Produto("Faca", 5.9),
            };

            carrinho.Add(livro);
            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);
            
            foreach(Produto produto in carrinho) {
                Console.WriteLine($"{produto.Nome} - R$ {produto.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // Set NÃO aceita repetições

            foreach(Produto item in carrinho) {
                Console.WriteLine($"- {item.Nome}: {item.Preco}");
            }
        }
    }
}
