using _16Exemplo02;
using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int productListSize = int.Parse(Console.ReadLine());

            Product[] productList = new Product[productListSize];
            double totalProductPrices = 0;

            for (int i = 0; i < productListSize; i++)
            {
                productList[i] = new Product();
                Console.Write("Digite o nome do produto número " + i + 1 + ": ");
                productList[i].Name = Console.ReadLine();
                Console.Write("Digite o preço do produto número " + i + 1 + ": ");
                productList[i].Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totalProductPrices += productList[i].Price;
            }

            double average = totalProductPrices / productListSize;
            Console.WriteLine("A média é: " + average.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}