using HMO.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface ICityService
    {
        Task<List<CityDTO>> GetAllAsync();
        Task<CityDTO> GetByIdAsync(int id);
        Task<CityDTO> AddAsync(CityDTO City);
        Task<CityDTO> UpdateAsync(CityDTO City);
        Task DeleteByIdAsync(int id);
    }
}
