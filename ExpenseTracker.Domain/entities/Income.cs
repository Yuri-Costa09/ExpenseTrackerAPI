using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Domain.entities;

public class Income
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "You must enter a description.")]
    public string Description { get; set; }
    [Required(ErrorMessage = "You must enter an amount.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    

    
}