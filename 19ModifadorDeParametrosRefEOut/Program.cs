using System;

namespace Projeto19ModificadorDeParametrosRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref faz o parâmetro ser uma referência para a variável original.
            //Sem o ref imprimiria 10 e não 30.
            //também exige que a palavra ref seja iniciada. Ou seja, não aceita se for int a;
            //deve ser evitado
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}