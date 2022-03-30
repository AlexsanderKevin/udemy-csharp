using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public struct Dependente {
        public string Nome; // String é uma CLASSE, ou seja, possui atribuição por REFERENCIA.
        public int Idade; // Int é uma STRUCt, ou seja, possui atribuição por VALOR.

    }
    class ValorVsReferencia {
        public static void Executar() {
            Dependente dep = new Dependente {
                Nome = "Kevin",
                Idade = 20,
            };

            Console.WriteLine($"{dep.Nome}, {dep.Idade}");
        }
    }
}
