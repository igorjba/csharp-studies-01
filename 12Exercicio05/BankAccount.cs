using System.Globalization;

namespace Bank
{
    internal class BankAccount
    {
        //atributos com property
        public int AccountId { get; private set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; private set; }

        //construtores
        public BankAccount(int accountId, string accountHolder)
        {
            AccountId = accountId;
            AccountHolder = accountHolder;
        }

        public BankAccount(int accountId,  string accountHolder, double initialDeposit) : this(accountId, accountHolder)
        {
            bankDeposit(initialDeposit);
        }

        public void bankDeposit(double balance)
        {
            AccountBalance += balance;
        }

        public void bankWithdrawal(double balance)
        {
            AccountBalance -= balance;
            AccountBalance -= 5.0;
        }

        //override
        public override string ToString()
        {
            return "Conta: "
                + AccountId
                + ", Titular: "
                + AccountHolder
                + ", Saldo: $"
                + AccountBalance.ToString("F2", CultureInfo.InvariantCulture)
                + ".";
        }

    }


}
