using Exercicio02;
using System.Globalization;

namespace Esideercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo side;

            side = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Largura: ");
            side.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            side.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA: " + side.CalculateRectangleArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + side.CalculateRectanglePerimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + side.CalculateRectangleDiagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}