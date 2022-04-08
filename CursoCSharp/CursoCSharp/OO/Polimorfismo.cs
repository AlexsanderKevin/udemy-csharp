using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
    }

    public class Feijao : Comida {
         //public double Peso;
         public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida {
        //public double Peso;
        public Arroz(double peso) : base(peso) { }
    }

    public class Carne : Comida {
        //public double Peso;
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa {
        public double Peso;

        public Pessoa() { }

        public Pessoa (double peso) {
            Peso = peso;
        }

        public void Comer(Comida comida) {
            Peso += comida.Peso;
            Console.WriteLine($"Comeu {comida.Peso}kg de comida");
        }
    }
    class Polimorfismo {
        public static void Executar() {
            Pessoa fulano = new Pessoa(70.0);
            Comida feijao = new Feijao(0.2);
            Comida arroz = new Arroz(0.3);
            Comida carne = new Carne(0.7);

            List<Comida> prato = new List<Comida>();
            prato.Add(feijao);
            prato.Add(arroz);
            prato.Add(carne);

            Console.WriteLine($"Peso do fulano: {fulano.Peso}");

            foreach(Comida comida in prato) {
                fulano.Comer(comida);
            }

            Console.WriteLine($"Peso do fulano: {fulano.Peso}");
        }
    }
}
