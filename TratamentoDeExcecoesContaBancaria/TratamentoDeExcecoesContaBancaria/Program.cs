using TratamentoDeExcecoesContaBancaria.Entities.Exceptions;
using System.Globalization;
using TratamentoDeExcecoesContaBancaria.Entities;

namespace TratamentoDeExcecoesContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account account = new Account {Number = number, Holder = holder, Balance = balance, WithdrawLimit = withdrawLimit };

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(amount);
                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}