namespace ExpenseTracker.Domain.entities;
using System;
using System.ComponentModel.DataAnnotations;

public class Expense
{
    [Key]
    public int Id { get; set; }
    public string? Description { get; set; }
    [Required]
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public int UserId { get; set; }
}