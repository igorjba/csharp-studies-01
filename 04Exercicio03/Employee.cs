namespace Projeto04Exercicio03
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;
        public double SalaryIncreasePercentage;

        public double CalculateNetSalary()
        {
            return GrossSalary - Tax;
        }

        public double CalculateSalaryIncrease()
        {
            return GrossSalary * (SalaryIncreasePercentage / 100) + CalculateNetSalary();
        }

    }
}
