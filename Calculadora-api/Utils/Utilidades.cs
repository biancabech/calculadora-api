using Calculadora_api.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Utils
{
    internal class Utilidades
    {
        public static double EscolherValor()
        {
            Console.WriteLine("Insira o valor");
            double valor = double.Parse(Console.ReadLine());
            //inserir validação
            return valor;
        }

        
    }
}
