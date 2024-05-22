namespace Exercicio02
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculateRectangleArea()
        {
            return Largura * Altura;
        }

        public double CalculateRectanglePerimeter()
        {
            return 2 * (Largura + Altura);
        }

        public double CalculateRectangleDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }


    }
}
