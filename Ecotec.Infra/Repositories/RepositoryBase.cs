using Ecotec.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ecotec.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        protected readonly EcotecContext _context;
        protected DbSet<TEntity> _dbSet;

        public RepositoryBase(EcotecContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        protected void Commit()
        {
            Commit();
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}