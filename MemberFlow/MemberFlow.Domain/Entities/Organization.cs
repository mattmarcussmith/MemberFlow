
namespace MemberFlow.Domain.Entities
{
    public class Organization
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedUtc { get; set; }
    }
}
