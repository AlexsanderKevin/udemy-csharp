using System;
using System.Collections.Generic; // Este import é necessário para este conteudo
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            int hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }

        //public Produto (string nome, double preco) {
        //    Nome = nome;
        //    Preco = preco;
        //}
        //public Produto() { }

        //// Método para sobrescrever um método padrão
        //public override bool Equals(object obj) {
        //    Produto outro = (Produto)obj;
        //    bool mermoNome = Nome == outro.Nome;
        //    bool mermoPreco = Preco == outro.Preco;

        //    return mermoNome && mermoPreco;
        //}

        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList {
        public static void Executar() {
            Produto livro = new Produto(nome: "Game of Thrones", preco: 49.9);
                                            // Generics    
            List <Produto> carrinho = new List <Produto>();

            List <Produto> combo = new List <Produto> {
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
            carrinho.Add(livro); // Lists aceitam dados REPETIDOS;

            foreach(Produto item in carrinho) {
                Console.WriteLine($"{carrinho.IndexOf(item)} - {item.Nome}: {item.Preco}");
            }
        }
    }
}
