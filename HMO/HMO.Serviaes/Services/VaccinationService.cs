using AutoMapper;
using HMO.Common.DTO;
using HMO.Repository.Entities;
using HMO.Repository.Interfaces;
using HMO.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Services
{
    public class VaccinationService : IVaccinationService
    {
        public readonly IVaccinationRepository _VaccinationRepository;
        public readonly IMapper _mapper;
        public VaccinationService(IVaccinationRepository VaccinationRepository, IMapper mapper)
        {
            _VaccinationRepository = VaccinationRepository;
            _mapper = mapper;
        }
        public async Task<VaccinationDTO> AddAsync(VaccinationDTO Vaccination1)
        {
            return _mapper.Map<VaccinationDTO>(await _VaccinationRepository.AddAsync(_mapper.Map<Vaccination>(Vaccination1)));
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _VaccinationRepository.DeleteByIdAsync(id);
        }

        public async Task<List<VaccinationDTO>> GetAllAsync()
        {
            return _mapper.Map<List<VaccinationDTO>>(await _VaccinationRepository.GetAllAsync());
        }

        public async Task<VaccinationDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<VaccinationDTO>(await _VaccinationRepository.GetByIdAsync(id));

        }

        public async Task<VaccinationDTO> UpdateAsync(VaccinationDTO Vaccination1)
        {
            return _mapper.Map<VaccinationDTO>(await _VaccinationRepository.UpdateAsync(_mapper.Map<Vaccination>(Vaccination1)));

        }
    }
}
