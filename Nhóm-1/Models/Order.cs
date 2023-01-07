using System;
using System.ComponentModel.DataAnnotations;
namespace nhóm_1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public float TotalMoney { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public ICollection<Customers>? Customer { get; set; }
    }
}
