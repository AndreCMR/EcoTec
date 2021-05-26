using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IDeleteRange<TEntity> where TEntity : class
    {
        void DeleteRange(List<TEntity> objects);
    }
}
