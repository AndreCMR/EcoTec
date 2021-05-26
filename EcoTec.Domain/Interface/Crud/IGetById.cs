using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IGetById<TEntity> where TEntity : class
    {
        TEntity GetById(Guid? id, bool isReadonly = false);
    }
}
