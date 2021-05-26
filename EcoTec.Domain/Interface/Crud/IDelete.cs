using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IDelete<TEntity> where TEntity : class
    {
        void Delete(TEntity obj);
    }
}
