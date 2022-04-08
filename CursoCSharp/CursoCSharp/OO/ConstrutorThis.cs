using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Animal { 
        public string Nome { get; set; }
    
        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
        
        public Cachorro(string nome, double altura) : this(nome) { // o uso de "this" faz com que o atributo "nome" seja construído de acordo com o construtor base
            Altura = altura;
        }

        public override string ToString() {
            return $"Nome: {Nome},\nAltura: {Altura}";
        }
    }

    class ConstrutorThis {
        public static void Executar() {
            Cachorro rex = new Cachorro(nome: "Rex", altura: 80);
            Console.WriteLine(rex); // o método "ToString()" está sendo aplicado de maneira implicita aqui;
        }
    }
}

