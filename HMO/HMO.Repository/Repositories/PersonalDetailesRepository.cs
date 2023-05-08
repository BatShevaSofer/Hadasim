using HMO.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Repositories
{
    public class PersonalDetailesRepository: IPersonalDetailesRepository
    {
        private readonly IContext _context;
        public PersonalDetailesRepository(IContext context)
        {
            _context = context;
        }
        public async Task<PersonalDetailes> AddAsync(PersonalDetailes PersonalDetailes)
        {
            var addedPersonalDetailes = await _context.PersonalDetailes.AddAsync(PersonalDetailes);
            await _context.SaveChangesAsync();
            return addedPersonalDetailes.Entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var PersonalDetailes = await GetByIdAsync(id);
            _context.PersonalDetailes.Remove(PersonalDetailes);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PersonalDetailes>> GetAllAsync()
        {
            return await _context.PersonalDetailes.ToListAsync();
        }

        public async Task<PersonalDetailes> GetByIdAsync(int id)
        {
            return await _context.PersonalDetailes.FindAsync(id);
        }

        public async Task<PersonalDetailes> UpdateAsync(PersonalDetailes PersonalDetailes)
        {
            var updatedPersonalDetailes = _context.PersonalDetailes.Update(PersonalDetailes);
            await _context.SaveChangesAsync();
            return updatedPersonalDetailes.Entity; ;
        }
    }
}
