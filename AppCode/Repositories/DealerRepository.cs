using Microsoft.EntityFrameworkCore;
using UluGidaGroup.AppCode.Infrastructure;
using UluGidaGroup.Models.Context;
using UluGidaGroup.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UluGidaGroup.AppCode.Repositories
{
    public class DealerRepository : AbstractRepository, IRepository<Dealer>
    {
        public DealerRepository(UluContext db)
            : base(db) { }  

        public Dealer Add(Dealer entity)
        {
            db.Dealers.Add(entity);
            return entity;
        }

        public async Task<Dealer> AddAsync(Dealer entity)
        {
            await db.Dealers.AddAsync(entity);
            return entity;
        }

        public IEnumerable<Dealer> AddRange(IEnumerable<Dealer> entities)
        {
            db.Dealers.AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<Dealer>> AddRangeAsync(IEnumerable<Dealer> entities)
        {
            await db.Dealers.AddRangeAsync(entities);
            return entities;
        }

        public void Delete(Dealer entity)
        {
            db.Dealers.Remove(entity);
        }

        public Dealer Edit(Dealer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<Dealer> GetAll(Expression<Func<Dealer, bool>> predicate = null)
        {
            if (predicate!= null)
            {
                return db.Dealers.Where(predicate);
            }
            return db.Dealers.AsQueryable();
        }

        public async Task<ICollection<Dealer>> GetAllAsync(Expression<Func<Dealer, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return await db.Dealers.Where(predicate).ToListAsync();
            }
            return await db.Dealers.ToListAsync();
        }

        public Dealer GetById(int id)
        {
            return db.Dealers.Find(id);
        }

        public async Task<Dealer> GetByIdAsync(int id)
        {
            return await db.Dealers.FindAsync(id);
        }

        public Dealer Update(Dealer entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<Dealer> UpdateRange(IEnumerable<Dealer> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
