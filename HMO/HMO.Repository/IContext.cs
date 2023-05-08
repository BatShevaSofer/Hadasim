using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMO.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HMO.Repository
{
    public interface IContext
    {
        DbSet<PersonalDetailes> PersonalDetailes { get; set; }

        DbSet<City> City { get; set; }

        DbSet<Producer> Producer { get; set; }
        DbSet<Vaccination> Vaccination { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
