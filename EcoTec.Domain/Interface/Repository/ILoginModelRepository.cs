using EcoTec.Domain.Entities;
using EcoTec.Domain.Interface.Crud;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTec.Domain.Interface.Repository
{
    public interface ILoginModelRepository : IDisposable, IAdd<LoginModel>
    {
        //
    }
}
