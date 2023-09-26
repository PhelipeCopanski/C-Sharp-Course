using EnumeracoesEComposicoes.Entities.Enums;
using System.Globalization;

namespace EnumeracoesEComposicoes.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
