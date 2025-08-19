using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Operacoes
{
    internal class Divisao
    {
        public string _Invalido = "Digite apenas números";
        public double ValorUm { get; private set; }
        public double ValorDois { get; private set; }
        public double Result { get; private set; }
        public Divisao(double valorUm, double valorDois) {
            this.ValorDois = valorDois;
            this.ValorUm = valorUm;
            this.Result = valorUm / valorDois;
        }
    }
}
