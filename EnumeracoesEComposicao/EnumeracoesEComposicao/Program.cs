using EnumeracoesEComposicoes.Entities;
using EnumeracoesEComposicoes.Entities.Enums;
using System.Globalization;

namespace EnumeracoesEComposicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client { BirthDate = birthDate, Name = name, Email = email };

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order { Client = client, Moment = DateTime.Now, Status = status };

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                Product product = new Product { Name = productName, Price = productPrice };
                OrderItem item = new OrderItem { Price = productPrice, Quantity = productQuantity, Product = product };
                order.AddItem(item);
            }
            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine(client);
            Console.WriteLine("Order items:");
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}