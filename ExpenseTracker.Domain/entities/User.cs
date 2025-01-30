using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.enums;

namespace ExpenseTracker.Domain.entities;

public class User 
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(75)]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    [StringLength(200)]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required.")]
    public string PasswordHash { get; set; }
    
    public Role Role { get; set; } // admin, user
    
    public ICollection<Income> Incomes { get; set; } = new List<Income>();
    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    
    public User() {}
    
    public User(string name, string email, string passwordHash, Role role)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }
    
}