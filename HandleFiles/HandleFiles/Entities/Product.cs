namespace HandleFiles.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}
