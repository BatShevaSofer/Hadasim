using HMO.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly IContext _context;
        public ProducerRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Producer> AddAsync(Producer Producer)
        {
            var addedProducer = await _context.Producer.AddAsync(Producer);
            await _context.SaveChangesAsync();
            return addedProducer.Entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var Producer = await GetByIdAsync(id);
            _context.Producer.Remove(Producer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Producer>> GetAllAsync()
        {
            return await _context.Producer.ToListAsync();
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            return await _context.Producer.FindAsync(id);
        }

        public async Task<Producer> UpdateAsync(Producer Producer)
        {
            var updatedProducer = _context.Producer.Update(Producer);
            await _context.SaveChangesAsync();
            return updatedProducer.Entity; ;
        }
    }
}
