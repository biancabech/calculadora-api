using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Operacoes {
    internal class Divisao {
        public string _Invalido = "Digite apenas números";
        public static double Entrada1 { get; set; }
        public static double Entrada2 {get; set; }
        public static double Resultado { get; set; }
        public Divisao(double valorUm, double valorDois) {
            Entrada2 = valorDois;
            Entrada1 = valorUm;
            Resultado = valorUm / valorDois;
        }
    }
}
