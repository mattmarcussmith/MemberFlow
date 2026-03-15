using MemberFlow.Domain.Entities;

namespace MemberFlow.Application.Interfaces.Security
{
    public interface IJwtTokenService
    { 
           string GenerateToken(User user);
    }
}
