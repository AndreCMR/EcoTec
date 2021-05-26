using Ecotec.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecotec.Application.Interface
{
    public interface ILoginModelAppService : IDisposable
    {
        void Adicionar(LoginViewModel loginViewModel);
    }
}
