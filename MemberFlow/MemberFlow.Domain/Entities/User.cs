using MemberFlow.Domain.Enums;

namespace MemberFlow.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public UserRoleStatus Role { get; set; }
        public string Email { get; set; }= string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedUtc { get; set; }

    }
}
