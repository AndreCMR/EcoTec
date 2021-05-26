using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IFind<TEntity> where TEntity : class
    {
        List<TEntity> Find(Expression<Func<TEntity, bool>> expression, bool isReadonly = false);
    }
}
