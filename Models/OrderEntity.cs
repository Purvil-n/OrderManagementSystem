namespace OrderManagementSystem.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentId { get; set; }
        public DateTime Date { get; set; }
        public Guid StatusId { get; set; }
    }
}
