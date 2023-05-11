using AutoMapper;
using HMO.Common.DTO;
using HMO.Repository;
using HMO.Repository.Interfaces;
using HMO.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Services
{
    public class PersonalDetailesService: IPersonalDetailesService
    {
        public readonly IPersonalDetailesRepository _PersonalDetailesRepository;
        public readonly IMapper _mapper;
        public PersonalDetailesService(IPersonalDetailesRepository PersonalDetailesRepository, IMapper mapper)
        {
            _PersonalDetailesRepository = PersonalDetailesRepository;
            _mapper = mapper;
        }
        public async Task<PersonalDetailesDTO> AddAsync(PersonalDetailesDTO PersonalDetailes1)
        {
            return _mapper.Map<PersonalDetailesDTO>(await _PersonalDetailesRepository.AddAsync(_mapper.Map<PersonalDetailes>(PersonalDetailes1)));
        }

        public async Task DeleteByIdAsync(string id)
        {
            await _PersonalDetailesRepository.DeleteByIdAsync(id);
        }

        public async Task<List<PersonalDetailesDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonalDetailesDTO>>(await _PersonalDetailesRepository.GetAllAsync());
        }

        public async Task<PersonalDetailesDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<PersonalDetailesDTO>(await _PersonalDetailesRepository.GetByIdAsync(id));

        }

        public async Task<PersonalDetailesDTO> UpdateAsync(PersonalDetailesDTO PersonalDetailes1)
        {
            return _mapper.Map<PersonalDetailesDTO>(await _PersonalDetailesRepository.UpdateAsync(_mapper.Map<PersonalDetailes>(PersonalDetailes1)));

        }
        public async Task<List<PersonalDetailesDTO>> GetByMonth()
        {
            return _mapper.Map<List<PersonalDetailesDTO>>(await _PersonalDetailesRepository.GetByMonth());

        }

    }
}
