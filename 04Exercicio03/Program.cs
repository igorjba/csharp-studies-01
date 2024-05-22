using System.Globalization;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeData;

            employeeData = new Employee();

            Console.WriteLine("Entre com nome, salário bruto e imposto:");

            Console.Write("Nome: ");
            employeeData.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employeeData.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employeeData.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\n");

            Console.WriteLine("Funcionário: " + employeeData.Name + " $ " + employeeData.CalculateNetSalary());
            Console.WriteLine("\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            employeeData.SalaryIncreasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\n");

            Console.WriteLine("Funcionário: " + employeeData.Name + " $ " + employeeData.CalculateSalaryIncrease().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}