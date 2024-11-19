namespace OrderManagementSystem.Models
{
    public class PaymentEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required List<Guid> ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid PaymentTypeId { get; set; }
        public Guid StatusId { get; set; }
        
    }
}
