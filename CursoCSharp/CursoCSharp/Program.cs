using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes", VariaveisEConstantes.Executar },
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar },
                // Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If / Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura Else If - Estruturas de Controle", EstruturaElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
            }); ;

            central.SelecionarEExecutar();
        }
    }
}