using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IGetByIdTypeInt<TEntity> where TEntity : class
    {
        TEntity GetByIdTypeInt(int? id, bool isReadonly = false);
    }
}
