using System;
using System.Globalization;

namespace Array_Classe
{
    //RAFAEL DO NASCIMENTO RODRIGUES RA 210211
    public class Program
    {
        static void Main(string[] args)
        {
            //mostrar ao usuário que ele tem que inserir a quantidade de pessoas
            Console.WriteLine("Insira a quantidade de pessoas");
            // conversão de string para double
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //declaração do array Altura
            double[] Altura = new double[quantidade];
            //declaração da variável soma
            double sum = 0.0;

            //utilização do foreach, para passar por cada elemento do array para inserir os dados necessários e realizar as contas necessárias
            foreach (double element in Altura)
            {
                // mostrar ao usuário que ele tem que inserir as alturas
                Console.WriteLine("insira a altura ");
                // conversão de string para double
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // operação matemática da soma, realizada a cada dado inserido
                sum += altura;

            }

            //calculo da media
            double media = sum / quantidade;
            //programa escrever o valor da media para visualização do usuário
            Console.WriteLine("A média é: " + media.ToString("F2", CultureInfo.InvariantCulture));
            //utilizei pois ó código está bugando sem ele
            Console.ReadKey();
        }
        
    }
}
