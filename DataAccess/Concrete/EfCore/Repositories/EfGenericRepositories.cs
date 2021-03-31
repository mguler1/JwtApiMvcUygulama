using DataAccess.Concrete.EfCore.Context;
using DataAccess.Interfaces;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore.Repositories
{
    public class EfGenericRepositories<Tentity> : IGenericDal<Tentity> where Tentity : class, ITable, new()
    {

        public async Task Add(Tentity entity)
        {
            using var context = new JwtContext();
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<Tentity>> GetAll()
        {
            using var context = new JwtContext();
            return await context.Set<Tentity>().ToListAsync();
        }

        public async Task<List<Tentity>> GetAllByFilter(Expression<Func<Tentity, bool>> filter)
        {
            using var context = new JwtContext();
            return await context.Set<Tentity>().Where(filter).ToListAsync();
        }

        public async Task<Tentity> GetByFilter(Expression<Func<Tentity, bool>> filter)
        {
            using var context = new JwtContext();
            return await context.Set<Tentity>().FirstOrDefaultAsync(filter);
        }

        public async Task<Tentity> GetById(int id)
        {
            using var context = new JwtContext();
            return await context.Set<Tentity>().FindAsync(id);
        }

        public async Task Remove(Tentity entity)
        {
            using var context = new JwtContext();
            context.Remove(entity);
          await  context.SaveChangesAsync();
        }

        public async Task Update(Tentity entity)
        {
            using var context = new JwtContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
