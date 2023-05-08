using HMO.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Interfaces
{
    public interface IVaccinationRepository
    {
        Task<List<Vaccination>> GetAllAsync();
        Task<Vaccination> GetByIdAsync(int id);
        Task<Vaccination> AddAsync(Vaccination Vaccination);
        Task<Vaccination> UpdateAsync(Vaccination Vaccination);
        Task DeleteByIdAsync(int id);
    }
}
