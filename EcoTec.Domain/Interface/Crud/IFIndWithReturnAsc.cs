using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IFindWhithReturnAsc<TEntendy> where TEntendy : class
    {
        IEnumerable<TEntendy> FindWithReturnAsc(Expression<Func<TEntendy, bool>> predicate, bool isReadonly = false);
    }
}
