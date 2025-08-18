using Calculadora_api.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_api.Utils
{
    internal class Utils
    {
       static public void EscolherOperacao()
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
            }while (continuar);
            
        }
        public double EscolherValor()
        {
            Console.WriteLine("Insira o valor");
            double valor = double.Parse(Console.ReadLine());
            //inserir validação
            return valor;
        }

        
    }
}
