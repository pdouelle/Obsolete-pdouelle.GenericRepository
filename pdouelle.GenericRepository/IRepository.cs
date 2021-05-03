using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using pdouelle.Entity;

namespace pdouelle.GenericRepository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = new());

        IQueryable<TEntity> Filter
        (
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null
        );

        Task<bool> SaveAsync(CancellationToken cancellationToken = new());
    }
}