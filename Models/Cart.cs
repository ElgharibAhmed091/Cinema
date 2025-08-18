namespace Cinema.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal TotalAmount => (decimal)Items.Sum(i => i.Price * i.Quantity);
    }
}
