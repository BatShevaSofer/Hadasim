using HMO.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface IVaccinationService
    {
        Task<List<VaccinationDTO>> GetAllAsync();
        Task<VaccinationDTO> GetByIdAsync(int id);
        Task<VaccinationDTO> AddAsync(VaccinationDTO Vaccination);
        Task<VaccinationDTO> UpdateAsync(VaccinationDTO Vaccination);
        Task DeleteByIdAsync(int id);
    }
}
