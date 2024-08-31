namespace Online_Store_Managment.Model
{
    public class Order
    {
        public int Id { get; set; }
        public virtual List<OrderedProducts> OrderedProducts { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public virtual int CustomerId { get; set; }

    }
}
