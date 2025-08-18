using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Executar
{
    public class ExecutarPrograma
    {
        public string _Invalido = "Digite apenas números";
        public static double Entrada1 { get; set; }
        public static double Entrada2 { get; set; }
        public static double Resultado { get; }

        public ExecutarPrograma(double entrada1, double entrada2)
        {
            Entrada1 = entrada1;
            Entrada2 = entrada2;
        }
        static public void Executar()
        {
            
        }

        
    }
}
