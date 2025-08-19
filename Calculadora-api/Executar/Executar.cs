using Calculadora_api.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Executar
{
    internal  class Executar : Soma
    {
        public Executar(string _invalido, double entrada1, double entrada2, double resultado) : base(_invalido, entrada1, entrada2, resultado)
        {
            _Invalido = _invalido;
            Entrada1 = entrada1;
            Entrada2 = entrada2;
            Resultado = resultado;
        }

        public virtual void Somar()
        {
            Console.WriteLine(Resultado);
        }
    }
}
