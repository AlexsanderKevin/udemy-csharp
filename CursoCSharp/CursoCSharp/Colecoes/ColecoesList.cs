using System;
using System.Collections.Generic; // Este import é necessário para este conteudo
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public Produto() { }
    }
    class ColecoesList {
        public static void Executar() {
            Produto livro = new Produto(nome: "Game of Thrones", preco: 49.9);
                                            // Generics    
            List<Produto> carrinho = new List<Produto>();

            List<Produto> combo = new List<Produto> {
                new Produto("Camisa", 59.9),
                new Produto("Calça", 99.9),
                new Produto("Faca", 5.9),
            };

            carrinho.Add(livro);
            carrinho.AddRange(combo);
            carrinho.RemoveAt(2);
            
            foreach(Produto produto in carrinho) {
                Console.WriteLine($"{carrinho.IndexOf(produto)} - {produto.Nome} - R$ {produto.Preco}");
            }
            Console.WriteLine(carrinho.Count); // Lists não têm a propriedade "Length".
            carrinho.Add(livro); // Lists aceitam dados repetidos;

            foreach(Produto item in carrinho) {
                Console.WriteLine($"{carrinho.IndexOf(item)} - {item.Nome}: {item.Preco}");
            }
        }
    }
}
