using System.ComponentModel.DataAnnotations;

namespace nhóm_1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? UserName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? Password { get; set; }
        public string? Rule { get; set; }
        public string? Status { get; set; }
    }
}
