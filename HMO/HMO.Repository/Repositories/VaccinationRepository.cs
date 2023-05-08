using HMO.Repository.Entities;
using HMO.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Repositories
{
    public class VaccinationRepository : IVaccinationRepository
    {
        private readonly IContext _context;
        public VaccinationRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Vaccination> AddAsync(Vaccination Vaccination)
        {
            var addedVaccination = await _context.Vaccination.AddAsync(Vaccination);
            await _context.SaveChangesAsync();
            return addedVaccination.Entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var Vaccination = await GetByIdAsync(id);
            _context.Vaccination.Remove(Vaccination);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Vaccination>> GetAllAsync()
        {
            return await _context.Vaccination.ToListAsync();
        }

        public async Task<Vaccination> GetByIdAsync(int id)
        {
            return await _context.Vaccination.FindAsync(id);
        }

        public async Task<Vaccination> UpdateAsync(Vaccination Vaccination)
        {
            var updatedVaccination = _context.Vaccination.Update(Vaccination);
            await _context.SaveChangesAsync();
            return updatedVaccination.Entity; ;
        }
    }
}
