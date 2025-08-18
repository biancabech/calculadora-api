using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Operacoes
{
    internal class Divisao
    {
        public double Result { get; private set; }
        public Divisao(double valorUm, double valorDois) {
            this.Result = valorUm / valorDois;
        }
    }
}
