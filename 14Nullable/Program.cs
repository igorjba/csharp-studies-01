namespace Projeto14Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basta colocar a interrogação para fazer um tipo que não aceita null passar a aceitar.
            double? x = null;
            double? y = 10.0;

            //GetValueOrDefault pega o valor da variável, se não houver pega o valor padrão da variável.
            Console.WriteLine("GetValueOrDefault");
            Console.WriteLine("x: " + x.GetValueOrDefault());
            Console.WriteLine("y: "+ y.GetValueOrDefault());
            Console.WriteLine();
            //verifica se há valor dentro da variável. O resultado é um boolean.
            Console.WriteLine("HasValue");
            Console.WriteLine("x: " + x.HasValue);
            Console.WriteLine("y: " + y.HasValue);
            Console.WriteLine();

            //Value retorna o valor da variável, dando erro se for null.
            //No caso abaixo, um if é necessário para não dar erro.
            //Console.WriteLine("Value");

            //Console.WriteLine("x: " + x.Value);
            //Console.WriteLine("y: " + y.Value);
            Console.WriteLine("Value");
            if (x.HasValue)
            {

                Console.WriteLine("x: " + x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {

                Console.WriteLine("y: " + y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            Console.WriteLine();
        }
    }
}