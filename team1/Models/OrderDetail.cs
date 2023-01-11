namespace team1.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public int? OrderId { get; set; }
    }
}
