using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            // 1 - Arrays são estruturas homogeneas, ou seja, todos os dados contidos são do mesmo tipo;
            // 2 - O tamanho de uma Array é fixo, uma vez criado com o tamanho 5, por exemplo, este permanecerá o tamanho para sempre;

            alunos[0] = "Kevin";
            alunos[1] = "Douglas";
            alunos[2] = "Paulo Andre";
            alunos[3] = "Pedro Scooby";
            alunos[4] = "Arthur";
            // alunos[5] = "Fulano"; // Não funciona porque excede o limite de itens definidos na criação da Array;

            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 6.5, 8.9, 9.7, 7.8 };

            foreach(double nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine($"Média: {media}");

            char[] letras = { 'K', 'e', 'v', 'i', 'n' };
            string palavra = new string(letras);
            Console.WriteLine($"Palavra: {palavra}");
        }
    }
}
