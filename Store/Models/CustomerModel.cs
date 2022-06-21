using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Store.Models
{
    public partial class CustomerModel
    {
        public static CustomerModel customer { get; set; }
        public CustomerModel()
        {
            Orderstables = new HashSet<OrdersModel>();
        }

        public int CustomerId { get; set; }
        public string? CustomerFullName { get; set; }
        
        [StringLength(50,MinimumLength = 10, ErrorMessage = "Your email is not correct")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Your email is not valid")]
        [Required]
        public string CustomerEmail { get; set; } = null!;

        [StringLength(50, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character")]
        [DataType("Password")]
        [Required]
        public string CustomerPassword { get; set; } = null!;
        public string? CustomerAddress { get; set; }
        public string? CustomerPhone { get; set; }

        public virtual ICollection<OrdersModel> Orderstables { get; set; }
    }
}
