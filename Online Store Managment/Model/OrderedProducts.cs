namespace Online_Store_Managment.Model
{
    public class OrderedProducts
    {
        public int Id { get; set; }

        public virtual int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
