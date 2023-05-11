using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Interfaces
{
    public interface IPersonalDetailesRepository
    {
        Task<List<PersonalDetailes>> GetAllAsync();
        Task<PersonalDetailes> GetByIdAsync(string id);
        Task<PersonalDetailes> AddAsync(PersonalDetailes PersonalDetailes);
        Task<PersonalDetailes> UpdateAsync(PersonalDetailes PersonalDetailes);
        Task DeleteByIdAsync(string id);
        Task<List<PersonalDetailes>> GetByMonth();
    }
}
