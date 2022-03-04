using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            Console.WriteLine("Formatando Números: ");

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // Valor como string com apenas uma casa decimal
            Console.WriteLine(valor.ToString("C"));
            // Valor monetário // nesse caso: R$
            Console.WriteLine(valor.ToString("P"));
            // Valor Percentual
            Console.WriteLine(valor.ToString("#.##")); 
            // Este é um template de como o número deve apaRECER // nesse caso com 2 casas decimais

            CultureInfo cultura = new CultureInfo("en-US");
            // nota: aparentemente a classe a partir da qual será criado um novo objeto deve ser passada como se fosse o tipo do objeto.
            Console.WriteLine(valor.ToString("C0", cultura));
            // valor monetário do país com base no objeto "cultura"criado acima, com 0 casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            // adiciona zeros à esquerda do numero alvo até que o número fique com um total de 10 algarismos (que é a quantidade passada como parametro)

        }
    }
}
