namespace Projeto31DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime representa o instante, o TimeSpan representa a duração.
            //horário atual do sistema
            DateTime d0 = DateTime.Now;

            Console.WriteLine(d0);
            Console.WriteLine(d0.Ticks);

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

        }
    }
}