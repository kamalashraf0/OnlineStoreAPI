using System.ComponentModel.DataAnnotations;

namespace Online_Store_Managment.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity in stock must be at least 0")]
        public int QuantityInStock { get; set; }

        [Required]
        public string Category { get; set; }

        public virtual ICollection<OrderedProducts> OrderedProducts { get; set; }

    }
}
