using UluGidaGroup.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UluGidaGroup.AppCode.Repositories
{
    abstract public class AbstractRepository
    {
        protected readonly UluContext db;
        public AbstractRepository(UluContext db)
        {
            this.db = db;
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await db.SaveChangesAsync();
        }

    }
}
