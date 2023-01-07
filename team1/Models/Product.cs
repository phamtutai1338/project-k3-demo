using System.ComponentModel.DataAnnotations;

namespace team1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? Detail { get; set; }
        public float Price { get; set; }
        public string? Image { get; set; }
        public float PriceNew { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int? Order { get; set; }
        public int Status { get; set; }
        public ICollection<GroupProduct>? GroupProducts { get; set; }
    }
}
