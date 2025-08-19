using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Operacoes
{
    internal abstract class Soma
    {
        public string _Invalido = "Digite apenas números";

        public static double Entrada1 { get; set; }

        public static double Entrada2 { get; set; }

        public static double Resultado { get; set; }

        public Soma(string _invalido, double entrada1, double entrada2, double resultado)
        {
            _Invalido = _invalido;
            Entrada1 = entrada1;
            Entrada2 = entrada2;
            Resultado = resultado;
        }

        public override void Somar()
        {
            if (Entrada1 != null && Entrada2 != null)
            {
                Resultado = Entrada1 + Entrada2;
            }
            else
            {
                Console.WriteLine(_Invalido);
            }

        }
    }
}

