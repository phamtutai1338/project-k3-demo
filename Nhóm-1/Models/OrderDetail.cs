using System;
namespace nhóm_1.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public ICollection<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
