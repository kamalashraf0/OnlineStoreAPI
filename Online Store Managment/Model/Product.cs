using System.ComponentModel.DataAnnotations;

namespace Online_Store_Managment.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
