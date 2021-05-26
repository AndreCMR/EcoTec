using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IGetAll<TEntity> where TEntity : class
    {
        List<TEntity> GetAll(bool isReadonly = false);
    }
}
