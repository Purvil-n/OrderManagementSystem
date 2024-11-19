namespace OrderManagementSystem.Models
{
    public class RoleEntity
    {
        public Guid Id { get; set; }
        public string RoleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
