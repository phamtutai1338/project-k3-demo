using System.ComponentModel.DataAnnotations;

namespace team1.Models
{
    public class GroupProduct
    {
        public int GroupProductId { get; set; }
        public string? Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? Content { get; set; }
        public string? image { get; set; }
        public int Order { get; set; }
        public string? Status { get; set; }
    }
}
