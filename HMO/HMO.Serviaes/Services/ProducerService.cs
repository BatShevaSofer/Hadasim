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
    public class ProducerService : IProducerService
    {
        public readonly IProducerRepository _ProducerRepository;
        public readonly IMapper _mapper;
        public ProducerService(IProducerRepository ProducerRepository, IMapper mapper)
        {
            _ProducerRepository = ProducerRepository;
            _mapper = mapper;
        }
        public async Task<ProducerDTO> AddAsync(ProducerDTO Producer1)
        {
            return _mapper.Map<ProducerDTO>(await _ProducerRepository.AddAsync(_mapper.Map<Producer>(Producer1)));
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _ProducerRepository.DeleteByIdAsync(id);
        }

        public async Task<List<ProducerDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ProducerDTO>>(await _ProducerRepository.GetAllAsync());
        }

        public async Task<ProducerDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ProducerDTO>(await _ProducerRepository.GetByIdAsync(id));

        }

        public async Task<ProducerDTO> UpdateAsync(ProducerDTO Producer1)
        {
            return _mapper.Map<ProducerDTO>(await _ProducerRepository.UpdateAsync(_mapper.Map<Producer>(Producer1)));

        }
    }
}
