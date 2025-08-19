using Calculadora_api.Utils;

namespace Calculadora_api.Operacoes
{
    internal class Subtracao
    {
        public static void Subtrair()
        {
            List<double> listaNumeros = new List<double>();
            
            Console.WriteLine("Deseja inserir quantos valores?");
            int quantidadeValores = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeValores; i++)
            {
                listaNumeros.Add(Utilidades.EscolherValor());
            }

            double resultado = listaNumeros[0];
            foreach (double valor in listaNumeros.Skip(1))
            {
                resultado -= valor;
            }

            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
