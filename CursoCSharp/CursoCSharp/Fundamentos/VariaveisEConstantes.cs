using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5; // atribuição
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45; // inteiro "curto"
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // byte que aceita numeros negativos
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue; // um tanto maior que o byte
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros // pode ser tanto positivo quanto negativo
            Console.WriteLine("Menor valor " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // inteiro sem sinal, vai mais longe para o lado dos positivos // pode-se utilizar o underline (underscore) _ para separar a cada três casas numéricas
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // este é o long, porem sem sinal. Ele vai muito além para o lado dos positivos.
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // sem o "f" no final não seria um float, e sim um double, que possui o dobro do tamanho. Armazenar valores bouble em variaveis float podem resultar em perda de informação.
            Console.WriteLine("Preco do Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // tipo mais utilizado para a representação de números Reais
            Console.WriteLine("Valor da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // utilizado para valores literalmente astronomicos
            Console.WriteLine("Distancia entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'a'; // delimitada sempre por aspas simples
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
