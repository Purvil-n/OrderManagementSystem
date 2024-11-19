using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Context
{
    public class OMSContext : DbContext
    {
        public OMSContext(DbContextOptions<OMSContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<PaymentTypeEntity> PaymentTypes { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<StatusEntity> Status { get; set; }

    }
}
