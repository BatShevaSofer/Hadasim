using HMO.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface IProducerService
    {
        Task<List<ProducerDTO>> GetAllAsync();
        Task<ProducerDTO> GetByIdAsync(int id);
        Task<ProducerDTO> AddAsync(ProducerDTO Producer);
        Task<ProducerDTO> UpdateAsync(ProducerDTO Producer);
        Task DeleteByIdAsync(int id);
    }
}
