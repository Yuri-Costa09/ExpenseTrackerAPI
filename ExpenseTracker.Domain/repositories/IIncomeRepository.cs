using ExpenseTracker.Domain.entities;

namespace ExpenseTracker.Domain.repositories;

public interface IIncomeRepository
{
    Task<Income> GetByIdAsync(int id);
    Task<Income> CreateAsync(Income income);
    Task<Income> UpdateAsync(Income income);
    Task<Income> DeleteAsync(Income income);
    
}