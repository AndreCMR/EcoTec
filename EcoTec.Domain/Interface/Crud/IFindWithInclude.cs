using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IFindWithInclude<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindWithInclude(Expression<Func<TEntity, bool>> predicate, bool isReadonly = false);
    }
}
