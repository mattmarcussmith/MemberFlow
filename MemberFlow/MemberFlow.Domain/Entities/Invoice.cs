using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int SubscriptionId { get; set; }
        public decimal Amount { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime DueDate { get; set; }
    }
}
