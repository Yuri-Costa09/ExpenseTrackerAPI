using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.repositories;

namespace ExpenseTracker.Domain.entities;

public class User 
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required.")]
    public string PasswordHash { get; set; }
    public Role Role { get; set; } // admin, user
    
    public User() {}
    
    public User(string name, string email, string passwordHash, Role role)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }
    
    public User(int id, string name, string email, string passwordHash, Role role)
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }
    
    
}