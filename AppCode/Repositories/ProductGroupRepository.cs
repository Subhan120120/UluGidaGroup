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
    public class ProductGroupRepository : AbstractRepository, IRepository<ProductGroup>
    {
        public ProductGroupRepository(UluContext db)
            : base(db) { }  

        public ProductGroup Add(ProductGroup entity)
        {
            db.ProductGroups.Add(entity);
            return entity;
        }

        public async Task<ProductGroup> AddAsync(ProductGroup entity)
        {
            await db.ProductGroups.AddAsync(entity);
            return entity;
        }

        public IEnumerable<ProductGroup> AddRange(IEnumerable<ProductGroup> entities)
        {
            db.ProductGroups.AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<ProductGroup>> AddRangeAsync(IEnumerable<ProductGroup> entities)
        {
            await db.ProductGroups.AddRangeAsync(entities);
            return entities;
        }

        public void Delete(ProductGroup entity)
        {
            db.ProductGroups.Remove(entity);
        }

        public ProductGroup Edit(ProductGroup entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<ProductGroup> GetAll(Expression<Func<ProductGroup, bool>> predicate = null)
        {
            if (predicate!= null)
            {
                return db.ProductGroups.Where(predicate);
            }
            return db.ProductGroups.AsQueryable();
        }

        public async Task<ICollection<ProductGroup>> GetAllAsync(Expression<Func<ProductGroup, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return await db.ProductGroups.Where(predicate).ToListAsync();
            }
            return await db.ProductGroups.ToListAsync();
        }

        public ProductGroup GetById(int id)
        {
            return db.ProductGroups.Find(id);
        }

        public async Task<ProductGroup> GetByIdAsync(int id)
        {
            return await db.ProductGroups.FindAsync(id);
        }

        public ProductGroup Update(ProductGroup entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<ProductGroup> UpdateRange(IEnumerable<ProductGroup> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
