using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Interfaces
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync();
        Task<City> GetByIdAsync(int id);
        Task<City> AddAsync(City City);
        Task<City> UpdateAsync(City City);
        Task DeleteByIdAsync(int id);
    }
}
