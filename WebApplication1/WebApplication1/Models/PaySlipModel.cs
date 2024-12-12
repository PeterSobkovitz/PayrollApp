namespace WebApplication1.Models
{
    public class PaySlip
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal NetSalary { get; set; }
        public bool EmailSent { get; set; }
    }

}
