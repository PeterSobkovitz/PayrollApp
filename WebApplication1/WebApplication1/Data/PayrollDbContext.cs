using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebApplication1.Models;

public class PayrollDbContext : IdentityDbContext<IdentityUser>
{
    // Constructor
    public PayrollDbContext(DbContextOptions<PayrollDbContext> options)
        : base(options)
    {
    }

    // DbSet properties
    public DbSet<User> Users { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<PaySlip> PaySlips { get; set; }
    public DbSet<SalaryTransaction> SalaryTransactions { get; set; }

    // Configuring relationships and table mapping
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Worker-PaySlip relationship
        modelBuilder.Entity<PaySlip>()
            .HasOne(p => p.Worker)
            .WithMany(w => w.PaySlips)
            .HasForeignKey(p => p.WorkerId)
            .OnDelete(DeleteBehavior.Cascade);

        // Worker-SalaryTransaction relationship
        modelBuilder.Entity<SalaryTransaction>()
            .HasOne(t => t.Worker)
            .WithMany(w => w.SalaryTransactions)
            .HasForeignKey(t => t.WorkerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
