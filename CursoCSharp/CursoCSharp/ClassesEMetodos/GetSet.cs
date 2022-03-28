using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        // private: significa que o dado não é público
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto (string marca, string modelo, uint cilindrada) {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto() { }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string novaMarca) {
            Marca = novaMarca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string novoModelo) {
            Modelo = novoModelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint novaCilindrada) {
            Cilindrada = novaCilindrada;
        }
    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawazaki", "Ninja XY-Z", 650);

            //Console.WriteLine(moto1.GetMarca());
            //Console.WriteLine(moto1.GetModelo());
            //Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
