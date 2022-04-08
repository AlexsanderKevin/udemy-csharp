using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    // Uma classe "sealed" é o completo oposto da "interface", porque não permite em hipotese alguma que a classe tenha herdeiros
    // força-se, portanto, que a classe "sealed" seja concreta;
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 13135;
        }
    }

    //class Filho : SemFilho { }; // NÃO é possível herdade de uma classe "sealed"

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() { // O método, antes marcado como "virtual", é reescrito como "sealed", fazendo com que seus herdeiros não possam sobrescreve-lo
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() { // NÃO é possivel sobrescrever o método graças à classe Pai;
        //    return false:
        //}
    }
    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Avo avo = new Avo();
            Pai pai = new Pai();
            FilhoRebelde filhoRebelde = new FilhoRebelde();

            Console.WriteLine(
                $"{semFilho.ValorDaFortuna()}\n" +
                $"{avo.HonrarNomeFamilia()}\n" +
                $"{pai.HonrarNomeFamilia()}\n" +
                $"{filhoRebelde.HonrarNomeFamilia()}\n"
            );
        }
    }
}
