using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    interface Teste {
        bool teste(string a);
    }
    interface OperacaoBinaria {
        // Os métodos e propriedades de uma interface são, por padrão, "public" e "abstract";
        int Operacao (int a, int b);
    }

    class Soma : OperacaoBinaria, Teste {
        // A interface obriga a classe herdeira a implementar seus membros;
        // A interface força os métodos a terem a mesma visibilidade nas classes herdeiras;
        public int Operacao (int a, int b) {
            return a + b;
        }
        
        public bool teste(string a) {
            return true;        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao (int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao (int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        public Calculadora() { }
        
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };

        public string ExecutarOperacoes (int a, int b) {
            string resultado = "";

            foreach (var op in operacoes) {
                resultado += $"{op.GetType()} = {op.Operacao(a,b)}\n";
            }

            return resultado.Replace("CursoCSharp.OO.", "");
        }
    }

    class Interface {
        public static void Executar() {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(4, 5));
        }
    }
}
