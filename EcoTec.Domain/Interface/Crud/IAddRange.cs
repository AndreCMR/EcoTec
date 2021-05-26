using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Crud
{
    public interface IAddRange<TEntity> where TEntity : class
    {
        void AddRange(List<TEntity> objects);
    }
}
