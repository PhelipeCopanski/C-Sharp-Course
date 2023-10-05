using System.Globalization;
using LinqEmployees.Entities;

namespace LinqEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee { Name = name, Email = email, Salary = salary });
                    }
                }

                Console.Write("Enter salary: ");
                double inputSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Email of people whose salary is more than {inputSalary}:");

                var emailUpperSalary = list.Where(e => e.Salary > inputSalary).OrderBy(e => e.Name).Select(e => e.Email);
                foreach (string e in emailUpperSalary)
                {
                    Console.WriteLine(e);
                }

                var sumInitialM = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumInitialM.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
