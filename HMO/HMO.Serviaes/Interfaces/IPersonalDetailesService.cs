using HMO.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface IPersonalDetailesService
    {
        Task<List<PersonalDetailesDTO>> GetAllAsync();
        Task<PersonalDetailesDTO> GetByIdAsync(int id);
        Task<PersonalDetailesDTO> AddAsync(PersonalDetailesDTO PersonalDetailes);
        Task<PersonalDetailesDTO> UpdateAsync(PersonalDetailesDTO PersonalDetailes);
        Task DeleteByIdAsync(int id);
    }
}
