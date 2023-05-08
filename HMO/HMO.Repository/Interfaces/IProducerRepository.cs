using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Interfaces
{
    public interface IProducerRepository
    {
        Task<List<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task<Producer> AddAsync(Producer GamePlayer);
        Task<Producer> UpdateAsync(Producer GamePlayer);
        Task DeleteByIdAsync(int id);
    }
}
