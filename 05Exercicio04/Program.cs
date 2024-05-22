using System.Globalization;

namespace Exercicio04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentData;
            studentData = new Student();

            Console.WriteLine("Entre com os dados do aluno:");
            Console.Write("Nome do aluno: ");
            studentData.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            studentData.GradeA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            studentData.GradeB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            studentData.GradeC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double finalGrade = studentData.CalculateFinalGrade();
            Console.WriteLine("NOTA FINAL = " + finalGrade.ToString("F2", CultureInfo.InvariantCulture));

            if (finalGrade >= 60.00)
            {
                Console.WriteLine("APROVADO");
            } else
            {
                double missingPoints = 60.00 - finalGrade;
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + missingPoints.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}