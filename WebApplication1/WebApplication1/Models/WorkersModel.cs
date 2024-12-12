namespace WebApplication1.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal TaxRate { get; set; }
        public decimal InsuranceRate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<PaySlip> PaySlips { get; set; }
        public ICollection<SalaryTransaction> SalaryTransactions { get; set; }
    }
}
