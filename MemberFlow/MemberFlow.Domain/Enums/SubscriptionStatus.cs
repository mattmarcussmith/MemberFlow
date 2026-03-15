using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberFlow.Domain.Enums
{
    public enum SubscriptionStatus
    {
        Pending = 0,
        Active = 1,
        Paused = 2,
        Cancelled = 3,
        Expired = 4,
    }
}
