using Lib.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.Service.Service
{
    public interface IInvestorsService
    {
        Task<IEnumerable<Investors>> GetAllAsync();
        Task<Investors> GetByIdAsync(int id);
        Task AddAsync(Investors actor);
        Task<Investors> UpdateAsync(int id, Investors newActor);
        Task DeleteAsync(int id);
    }
}