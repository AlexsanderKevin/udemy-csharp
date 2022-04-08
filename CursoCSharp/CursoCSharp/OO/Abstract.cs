using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    // Classes marcadas como "abstract" não podem ser instanciadas
    // elas servem apenas para transmitir seus atributos e métodos 
    // para as classes concretas através de herança.
    public abstract class Celular {
        // Métodos marcados como "abstract" não precisam ser inicializadas, elas apenas indicam que
        // a classe concreta que herdar da abstrata deve ter um método de mesma assinatura;
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        // A palavra "override" deve ser utilizada SEMPRE que um método for sobrescrito, até mesmo os métodos abstratos
        // que nem mesmo foram definidos.
        public override string Assistente() {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Ciri!";
        }
    }
    class Abstract {
        public static void Executar() {
            Celular galaxy = new Samsung();
            Console.WriteLine(galaxy.Assistente());

            Celular ultra_plus = new IPhone();
            Console.WriteLine(ultra_plus.Assistente());
        }
    }
}
