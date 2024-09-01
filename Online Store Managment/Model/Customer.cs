using System.ComponentModel.DataAnnotations;

namespace Online_Store_Managment.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Phone, Required]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;


        public virtual ICollection<Order> Orders { get; set; }

    }
}
