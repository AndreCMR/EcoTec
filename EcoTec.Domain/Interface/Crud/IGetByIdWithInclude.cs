using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IGetByIdWithInclude<TEntity> where TEntity : class
    {
        TEntity GetByIdWithInclude(Guid? id, bool isReadonly = false);
    }
}
