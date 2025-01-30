using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Domain.entities;

public class Category
{
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(50)] 
    public string Name { get; set; }
    [StringLength(200)]
    public string Description { get; set; }
    
    public ICollection<Expense> Expenses { get; set; }
    public ICollection<Income> Incomes { get; set; }
}