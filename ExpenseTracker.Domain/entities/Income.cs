namespace ExpenseTracker.Domain.entities;

public class Income
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public int UserId { get; set; }
    
    
}