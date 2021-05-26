using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IGetAllWithInclude<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllWithInclude(bool isReadonly = false);
    }
}
