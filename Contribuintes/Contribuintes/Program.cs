using Contribuintes.Entities;
using System.Globalization;

namespace Contribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse (Console.ReadLine());
                    list.Add(new Company(employees, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTax = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
                totalTax += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}