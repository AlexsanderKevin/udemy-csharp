using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    interface Ponto {
        // Métodos de interface são PUBLICOS por padrão
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada (int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            throw new NotImplementedException();
        }

        public void MoverParaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    class Struct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine($"Coordenada inicial ({coordenadaInicial.X}; {coordenadaInicial.Y})");

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine($"({coordenadaFinal.X}; {coordenadaFinal.Y})");
        }
    }
}
