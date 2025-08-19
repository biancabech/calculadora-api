using Calculadora_api.Operacoes;
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
        public static void Executar()
        {
            bool continuar = false;
            do
            {
                Console.WriteLine("insira a operação que deseja fazer ");
                Console.WriteLine("+ : Adição");
                Console.WriteLine("- : Subtração");
                Console.WriteLine("* : Multiplicação");
                Console.WriteLine("/ : Divisão");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "+":

                        break;
                    case "-":
                        Subtracao.Subtrair();
                        break;
                    case "*":

                        break;
                    case "/":

                        break;
                    default:
                        Console.WriteLine("Valor inválido escolha novamente ");
                        continuar = true;
                        break;
                }
                continuar = false;
            } while (continuar);
        }

        
    }
}
