using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Domain.Entities;

namespace HRM.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<PersonEmployee>> GetAllAsync();
        Task<PersonEmployee?> GetByIdAsync(int id);
        Task<PersonEmployee> AddAsync(PersonEmployee employee);
        Task UpdateAsync(PersonEmployee employee);
        Task DeleteAsync(int id);
    }
}
