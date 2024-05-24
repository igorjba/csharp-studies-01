using System.Globalization;

namespace Projeto15Exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do array: ");
            int tamanhoDoArray = int.Parse(Console.ReadLine());

            double[] vect = new double[tamanhoDoArray];
            double sum = 0;

            for (int i = 0; i  < tamanhoDoArray; i++)
            {
                Console.Write("Digite o número da posição " + i + " do array: ");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            double average = sum / tamanhoDoArray;
            Console.WriteLine("A média é: " + average.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}