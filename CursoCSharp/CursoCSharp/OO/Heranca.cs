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

        public virtual int Acelerar() { // "virtual" significa que o método PODE ser sobrescrito.
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        // Essa classe herda o construtor padrão da classe pai "Carro" caso exista;

        public Uno() : base(200) { }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(450) { }

        public override int Acelerar() { // "override" sobrescreve APENAS membros marcados como "virtual";
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai;
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno ();
            Console.WriteLine($"acelerar: {carro1.Acelerar()}");
            Console.WriteLine($"acelerar: {carro1.Acelerar()}");
            Console.WriteLine($"freiar: {carro1.Frear()}");
            Console.WriteLine($"freiar: {carro1.Frear()}");

            Console.WriteLine("Ferrari 1");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Frear()}");

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Frear()}"); // neste caso o método Frear() é o mesmo da classe genérica "Carro";

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno();
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Frear()}");
        }
    }
}
