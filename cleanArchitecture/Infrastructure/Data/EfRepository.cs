using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : class, new()
    {
        protected readonly ApplicationContext _dbContext;

        public EfRepository(ApplicationContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return _dbContext.Set<T>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }
        }
        public async Task<T> AddAsync(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must be not be null");
            }
            try
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dbContext.Update(entity);
                await _dbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }
    }
}
