namespace OrderManagementSystem.Models
{
    public class UserEntity
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
}
