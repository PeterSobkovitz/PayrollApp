namespace WebApplication1.Models
{
    public class SalaryTransaction
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string TransactionReference { get; set; }
    }

}
