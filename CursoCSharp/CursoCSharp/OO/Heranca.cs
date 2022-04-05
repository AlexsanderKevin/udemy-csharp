using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual; // Privado

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }
        //public Carro() { }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            
            return VelocidadeAtual;
        }

        public int Acelerar() {
            return AlterarVelocidade(5);
        }
        public int Freiar() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        // Essa classe herda o construtor padrão da classe pai "Carro" caso exista;

        public Uno() : base(200) { }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(450) { }
    }
    class Heranca {
        public static void Executar() {
            Uno carro1 = new Uno ();
            Console.WriteLine($"acelerar: {carro1.Acelerar()}");
            Console.WriteLine($"acelerar: {carro1.Acelerar()}");
            Console.WriteLine($"freiar: {carro1.Freiar()}");
            Console.WriteLine($"freiar: {carro1.Freiar()}");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Acelerar()}");
        }
    }
}
