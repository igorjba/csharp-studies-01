namespace Projeto30FuncoesStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            //tudo maiusculo
            string s1 = original.ToUpper();
            //tudo minusculo
            string s2 = original.ToLower();
            //apaga os espaços em branco antes e depois da string
            string s3 = original.Trim();

            //identifica o index do termo buscado na string olhando do inicio ao fim.
            int n1 = original.IndexOf("bc");
            //identifica o index do termo buscado na string olhando do fim ao inicio.
            int n2 = original.LastIndexOf("bc");

            //corta a string a partir da posição indicada
            string s4 = original.Substring(3);
            //corta a string a partir da posição indicada e limita a quantidade de caracteres que serão usados, o resto é retirado.
            string s5 = original.Substring(3, 5);

            //substitui uma parte da função por outra. (trocou todo o char o por char x)
            string s6 = original.Replace('a', 'x');
            //substitui uma parte da função por outra, não precisa ser do mesmo tamanho. (trocou toda a string abc por string xy)
            string s7 = original.Replace("abc", "xy");

            //testa se a string é vazia ("") ou null
            bool b1 = String.IsNullOrEmpty(original);
            //testa se a string é um espaço em branco (" ") ou null
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}