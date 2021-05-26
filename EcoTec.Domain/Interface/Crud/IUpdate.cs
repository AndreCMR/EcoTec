using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IUpdate<TEntity> where TEntity : class
    {
        void Update(TEntity obj);
    }
}
