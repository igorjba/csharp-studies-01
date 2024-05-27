namespace Projeto27InferenciaDeTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var remove a necessidade de declarar o tipo, pois ele já faz automáticamente.
            
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            var a = 'M';

            //Usar var pode trazer problemas, pois o computador não consegue te ajudar caso você insira o tipo errado, afinal ele passou aceitar qualquer tipo.
            //Ou seja, na teoria, ingessar a varivavel declarando o tipo, dá mais trabalho, mas pode trazer facilidades na identificação, prevenção e correção de erros.
            var w = z;

            int i = 0;

            //O pc já sinaliza o erro.
            //string h = i;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
        }
    }
}