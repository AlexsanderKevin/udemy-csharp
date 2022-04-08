using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

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
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar },

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Parametros Variaveis - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get e Set - Classes e Métodos", GetSet.Executar },
                {"Propriedades - Classes e Métodos", Props.Executar },
                {"Read Only - Classes e Métodos", ReadOnly.Executar },
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", Struct.Executar },
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar },
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parametros por referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parametro com valor Padrão - Classes e Métodos", ValorPadrão.Executar },

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecaoStack.Executar },
                {"Dictionary - Coleções", ColecaoDictionary.Executar },

                // OO
                {"Herança - OO", Heranca.Executar },
                {"Contrutor This - OO", ConstrutorThis.Executar },
                {"Polimorfismo", Polimorfismo.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
