using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberFlow.Domain.Enums
{
    public enum InvoiceStatus
    {
        Open = 0,
        Closed = 1,
        Paid = 2,
        Overdue = 3,
        Void = 4,
        Draft = 5,

    }
}
