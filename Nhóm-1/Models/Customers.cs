using System.ComponentModel.DataAnnotations;
namespace nhóm_1.Models
{
    public class Customers
    {
        public int CustomersId { get; set; }
        public string? CustomerName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDay { get; set; }
        public string? Province { get; set; }
        public string? Address { get; set; }
        public int Tel { get; set; }
        public string? Email { get; set; }
    }
   
}
