using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; } 
        public int OrganizationId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDateUtc { get; set; }
    }
}
