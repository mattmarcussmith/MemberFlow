namespace MemberFlow.Domain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string Email { get; set; }= string.Empty;
        public DateTime CreatedUtc { get; set; }
    }
}
