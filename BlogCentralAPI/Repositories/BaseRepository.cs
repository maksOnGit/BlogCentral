


using BlogCentralAPI.Data;
using BlogCentralLib.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCentralAPI.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T: class
    {
        protected readonly DataContext _dbContext;
      

        public BaseRepository(DataContext ctx)
        {
            _dbContext = ctx;
             
        }


        public virtual async Task<T> Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }

        public virtual async Task<T> Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }

        public virtual async Task<T> DeleteById(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return null;
            }
            return await Delete(entity);
        }

        public virtual IQueryable<T> GetAll()
        {
            // AsNoTracking geen cache
            return _dbContext.Set<T>().AsNoTracking();
        }
        public virtual async Task<IEnumerable<T>> ListAll()
        {
            return await GetAll().ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            throw new System.NotImplementedException();
            //return await _dbContext.Set<T>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<T> Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }
    }
}
