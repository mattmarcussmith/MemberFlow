using Microsoft.EntityFrameworkCore;
using MemberFlow.Domain.Entities;

namespace MemberFlow.Infrastructure.Persistence
{
    public class MemberFlowDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Refund> Refunds { get; set; }

        public DbSet<MembershipPlan> MembershipPlans { get; set; }
    }
}