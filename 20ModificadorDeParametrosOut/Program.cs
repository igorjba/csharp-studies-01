using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref faz o parâmetro ser uma referência para a variável original.
            //Sem o ref imprimiria 10 e não 30.
            //deve ser evitado
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}