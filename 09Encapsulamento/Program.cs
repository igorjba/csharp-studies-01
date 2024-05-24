namespace Projeto09Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}