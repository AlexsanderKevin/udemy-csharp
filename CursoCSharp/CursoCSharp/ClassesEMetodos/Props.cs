using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Props {
        public class CarroOpcional {
            double desconto = 0.1;

            string nome;
            public string Nome {
                get {
                    return "Opcional: " + nome;
                } set {
                    nome = value;
                    // "value" é uma palavra reservada que faz referencia ao valor passado ao método set
                }
            }

            // propriedade auto implementada
            public double Preco { get; set; }

            // somente leitura
            public double PrecoComDesconto {
                get => Preco - (desconto * Preco); // lambda (arrow function)
                //get {
                //    return Preco - (desconto * Preco);
                //}
            }

            public CarroOpcional() { }
            public CarroOpcional(string nome, double preco) {
                this.nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() {
            var opt1 = new CarroOpcional("Ar Condicionado", 3499);
            Console.WriteLine(opt1.PrecoComDesconto);

            //opt1.PrecoComDesconto = 34000; // não funciona, porque esta propriedade possui apenas o método "get" e não o "set"
            var opt2 = new CarroOpcional();
            opt2.Nome = "Direção Eletrica";
            opt2.Preco = 2500;

            Console.WriteLine(opt2.Nome);
        }
    }
}
