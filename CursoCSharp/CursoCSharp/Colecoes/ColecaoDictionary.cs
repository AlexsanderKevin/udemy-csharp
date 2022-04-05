using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecaoDictionary {
        public static void Executar() {
                                                         // chave - NÃO repete
            Dictionary<int, string> filmes = new Dictionary<int, string>();
                                                              // valor - PODE repetir
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "As branquelas");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "Homem Aranha 3");

            void showAll(Dictionary<int, string> dict) {
                foreach(var item in dict) {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            showAll(filmes);

            if (filmes.ContainsKey(2002)) {
                Console.WriteLine($"\n2002 - {filmes[2002]}");
                Console.WriteLine(filmes.ContainsValue("Bacurau"));
            }

            bool removeu = filmes.Remove(2002); // Remove retorna um boolean indicando se foi possível a remoção;
            Console.WriteLine($"\nRemoveu? {removeu}");
            showAll(filmes);

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"\nfilme 2006 - {filme2006}\n");

            // Percorrer chaves
            foreach (int chave in filmes.Keys) {
                Console.WriteLine($"{chave}");
            }
            // Percorrer valores
            foreach (string valor in filmes.Values) {
                Console.WriteLine($"{valor}");
            }
            // Percorrer chave e valor
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
