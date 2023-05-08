using HMO.Repository.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HMO.Repository.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly IContext _context;
        public CityRepository(IContext context)
        {
            _context = context;
        }
        public async Task<City> AddAsync(City City)
        {
            var addedCity = await _context.City.AddAsync(City);
            await _context.SaveChangesAsync();
            return addedCity.Entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var City = await GetByIdAsync(id);
            _context.City.Remove(City);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.City.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _context.City.FindAsync(id);
        }

        public async Task<City> UpdateAsync(City City)
        {
            var updatedCity = _context.City.Update(City);
            await _context.SaveChangesAsync();
            return updatedCity.Entity; ;
        }
    }
}
