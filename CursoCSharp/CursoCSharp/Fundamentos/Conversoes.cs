using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            Console.WriteLine("Conversões: ");

            int inteiro = 10;
            double quebrado = inteiro;
            // haveria um erro caso o tipo da variavel "inteiro" tivesse um valor maior do que a variavel "quebrado"
            // ou caso um dos dois tivesse suporte a números negativos e o outro não
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // isso remove o numero depois da vírgula sem arredondar
            Console.WriteLine($"Nota: {nota}, Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");

            string idadeString = Console.ReadLine();
            // int idadeInteiro = int.Parse(idadeString);
            int idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade inteiro: {idadeInteiro}");

            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            // int numero;
            // int.TryParse(palavra, out numero);
            // isso  tenta converter o valor passado como primeiro parametro e colocar o valor convertido na variavel passada
            // como segundo parametro
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);
        }
    }
}
