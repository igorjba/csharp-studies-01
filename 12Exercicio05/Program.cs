using System.Globalization;

namespace Projeto12Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string accountName = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char initialValueCheckResponse = char.Parse(Console.ReadLine());
            if (initialValueCheckResponse == 's' || initialValueCheckResponse == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(accountNumber, accountName, initialValue);
            }
            else
            {
                account = new BankAccount(accountNumber, accountName);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre o valor para depósito: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.bankDeposit(balance);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
            
            Console.WriteLine();
            Console.Write("Entre o valor para saque: ");
            balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.bankWithdrawal(balance);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}