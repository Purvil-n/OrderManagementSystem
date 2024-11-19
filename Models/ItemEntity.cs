namespace OrderManagementSystem.Models
{
    public class ItemEntity
    {
        public Guid Id { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualPrice { get; set; }
        public int DiscountPrice { get; set; }
        public int NewPrice { get; set; }
        public Guid RoleId { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
    }
}
