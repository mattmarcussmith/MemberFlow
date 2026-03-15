using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class Refund
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public RefundStatus Status { get; set; }    
        public DateTime CreatedUtc { get; set; }
    }
}