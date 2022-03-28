using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        // a palavra reservada "readonly" indica um valor que, após criada a instancia, torna-se imutavel. É como se fosse uma constante
        // mas sem a necessidade de ser inicializada com algum valor
        readonly DateTime Nascimento;

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
