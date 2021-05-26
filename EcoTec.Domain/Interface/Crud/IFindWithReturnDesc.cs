using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IFindWithReturnDesc<TEntendy> where TEntendy : class
    {
        IEnumerable<TEntendy> FindWithReturnDesc(Expression<Func<TEntendy, bool>> predicate, bool isReadonly = false);
    }
}
