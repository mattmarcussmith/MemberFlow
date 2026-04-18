using FinancialManagement.Domain.Enums;

namespace FinancialManagement.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public CategoryType CategoryType { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
