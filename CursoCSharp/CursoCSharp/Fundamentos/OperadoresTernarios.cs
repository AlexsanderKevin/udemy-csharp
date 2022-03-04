﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresTernarios {
        public static void Executar() {
            Console.WriteLine("Operadores Ternários");
            // Tambem conhecido como atribuição condicional

            double nota = 7.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
