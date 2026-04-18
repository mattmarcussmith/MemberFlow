namespace FinancialManagement.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string IdentityProviderId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
