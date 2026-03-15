using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int MemberId { get; set; }
        public int MembershipPlanId { get; set; }
        public SubscriptionStatus Status { get; set; }

        public DateTime CreatedUtc { get; set; }
        public DateTime StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}
