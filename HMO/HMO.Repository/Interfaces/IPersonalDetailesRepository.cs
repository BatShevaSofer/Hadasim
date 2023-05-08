﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Interfaces
{
    public interface IPersonalDetailesRepository
    {
        Task<List<PersonalDetailes>> GetAllAsync();
        Task<PersonalDetailes> GetByIdAsync(int id);
        Task<PersonalDetailes> AddAsync(PersonalDetailes PersonalDetailes);
        Task<PersonalDetailes> UpdateAsync(PersonalDetailes PersonalDetailes);
        Task DeleteByIdAsync(int id);
    }
}