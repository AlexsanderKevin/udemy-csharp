using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }
    class ReadOnly {
        public static void Executar() {
            var novoCliente = new Cliente("Kevin Alexsander de Jesus", new DateTime(2002, 03, 09));
            Console.WriteLine($"{novoCliente.Nome} - {novoCliente.GetDataDeNascimento()}");
        }
    }
}
