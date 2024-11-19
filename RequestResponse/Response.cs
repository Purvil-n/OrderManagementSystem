namespace OrderManagementSystem.RequestResponse
{
    public class Response
    {
    }
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string UserCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Guid RoleId { get; set; }
        public bool IsActive { get; set; }
    }
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualPrice { get; set; }
        public int DiscountPrice { get; set; }
        public int NewPrice { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
    }

    public class OrderResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentId { get; set; }
        public DateTime Date { get; set; }
        public Guid StatusId { get; set; }
    }

    public class PaymentResponse
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

    public class PaymentTypeResponse
    {
        public Guid Id { get; set; }
        public string PaymentTypeCode { get; set; }
        public string Name { get; set; }
    }

    public class RoleResponse
    {
        public Guid Id { get; set; }
        public string RoleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }

    public class StatusResponse
    {
        public Guid Id { get; set; }
        public string StatusCode { get; set; }
        public string Name { get; set; }
    }
    public class AllDetailUserResponse
    {
        public Guid UserId { get; set; }
        public string UserCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Guid PaymentId { get; set; }
        public required List<Guid> ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid PaymentTypeId { get; set; }
        public Guid PaymentStatusId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid OrderStatusId { get; set; }

    }
}
