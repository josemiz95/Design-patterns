using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.ExecuteTransactions();
        }
    }

    class Demo
    {
        public static void ExecuteTransactions()
        {
            var bankAccount = new BankAccount();

            var compositeBankAccount = new CompositeCommands();

            compositeBankAccount.Add(new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100));
            compositeBankAccount.Add(new BankAccountCommand(bankAccount, BankAccountCommand.Action.Withdraw, 50));

            compositeBankAccount.Execute();
            Console.WriteLine(bankAccount);

            compositeBankAccount.Undo();
            Console.WriteLine(bankAccount);
        }
    }
}
