using System;

namespace calcular
{
    class Program
    {
        static void Main()
        {
            Calcular C = new Calcular();

            Console.WriteLine("Informe o Valor inicial: ");
            C.ValorInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade das parcelas: ");
            C.qtdeParcelas = int.Parse(Console.ReadLine());

            double resultado = C.CalcularParcelas();

            Console.WriteLine(resultado);

            Console.ReadKey();

        }
    }

    public class Calcular
    {
        public double ValorInicial, resultado;
        public int qtdeParcelas;

        public double CalcularParcelas()
        {
            double parcelas = 0;

            parcelas = qtdeParcelas / ValorInicial;

            if (qtdeParcelas > 5)
            {
                parcelas = parcelas / (1 / 100);
            }
            return parcelas;
        }


    }
}
