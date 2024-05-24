namespace Projeto13TiposDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==> variaveis do tipo referência. Uma delas é a classe. São ponteiros e não caixas:

            //aqui a variável do tipo Classe ainda não foi criada de fato. Ela foi apenas apontada numa área chamada Stack. Tipo um atalho criado para endereço algum.
            Product p1, p2;

            //aqui sim é criado no Heap e gerado o endereço que o atalho (apontamento) de cima usará para chamá-la no heap
            p1 = new Product("TV", 900.00, 0);
            //p2 aponta para o mesmo heap que p1.
            p2 = p1;

            //
            p2 = null;

            // ==> variaveis do tipo valor. Uma delas são os structs. São caixas e não ponteiros.
            //são os tipos básicos. Ex.: double, int, float. DateTime, TimeSpan.
            double x, y;
            x = 10;

            //y recebe uma cópia de x.
            y = x;

            //mesmo sendo struct, é necessário inicializar
            Point p;
            //dessa forma, inserindo os valores
            p.X = 10;
            p.Y = 10;

            Console.WriteLine(p);

            //ou dessa forma colocando new (geralmente não precisa desse _13TiposDeVariaveis, é só o Point() mesmo).
            p = new Point();
            Console.WriteLine(p);

            //valores padrão:

            //números: 0
            //bool: false
            //char: caractere código 0
            //objeto: null
            //Uma variável apenas declarada, mas não instanciada, inicia em estado "não atrubuida", o próprio compilador não permite que seja acessada.



        }
    }
}