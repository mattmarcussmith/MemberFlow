using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class MembershipPlan
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public BillingCycleStatus Status { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
