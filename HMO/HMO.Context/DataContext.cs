using HMO.Repository;
using HMO.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Context
{
    public class DataContext :DbContext , IContext
    {

        

        public DbSet<PersonalDetailes> PersonalDetailes { get; set; }

        public DbSet<Producer> Producer { get; set; }

        public DbSet<Vaccination> Vaccination { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return base.Entry(entity);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HMO;Trusted_Connection=True;");
        
    }
}
