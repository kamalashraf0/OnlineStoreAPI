using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Online_Store_Managment.Model
{
    public class Order
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Status { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<OrderedProducts> OrderedProducts { get; set; }

        [ForeignKey("CustomerId")]
        [JsonIgnore]
        public virtual Customer Customer { get; set; }

    }
}
