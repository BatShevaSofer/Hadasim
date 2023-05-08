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
    public class CityService : ICityService
    {
        public readonly ICityRepository _CityRepository;
        public readonly IMapper _mapper;
        public CityService(ICityRepository CityRepository, IMapper mapper)
        {
            _CityRepository = CityRepository;
            _mapper = mapper;
        }
        public async Task<CityDTO> AddAsync(CityDTO City1)
        {
            return _mapper.Map<CityDTO>(await _CityRepository.AddAsync(_mapper.Map<City>(City1)));
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _CityRepository.DeleteByIdAsync(id);
        }

        public async Task<List<CityDTO>> GetAllAsync()
        {
            return _mapper.Map<List<CityDTO>>(await _CityRepository.GetAllAsync());
        }

        public async Task<CityDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<CityDTO>(await _CityRepository.GetByIdAsync(id));

        }

        public async Task<CityDTO> UpdateAsync(CityDTO City1)
        {
            return _mapper.Map<CityDTO>(await _CityRepository.UpdateAsync(_mapper.Map<City>(City1)));

        }
    }
}
