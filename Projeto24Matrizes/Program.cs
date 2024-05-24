namespace Projeto24Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            //Quantos elementos a matriz tem no total
            Console.WriteLine(matriz.Length); //6

            //Quanto é a primeira dimensão da matriz (quantidade de linhas). 
            Console.WriteLine(matriz.Rank); //2

            //Tamanho da dimensão especificada (no caso zero é a primeira dimensão - linhas)
            Console.WriteLine(matriz.GetLength(0)); //2

            //Tamanho da dimensão especificada (no caso um é a segunda dimensão - colunas)
            Console.WriteLine(matriz.GetLength(1)); //3
        }
    }
}