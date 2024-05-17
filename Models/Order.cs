namespace lab_1_asp_net.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MovieName { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
