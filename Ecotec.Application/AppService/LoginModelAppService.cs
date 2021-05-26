using System;
using System.Collections.Generic;
using System.Text;
using Ecotec.Application.Factory;
using Ecotec.Application.Interface;
using Ecotec.Application.ViewModel;
using EcoTec.Domain.Entities;
using EcoTec.Domain.Interface.Repository;

namespace Ecotec.Application.AppService
{
    public class LoginModelAppService : ILoginModelAppService
    {
        private readonly ILoginModelRepository _repository;

        public LoginModelAppService(ILoginModelRepository repository)
        {
            _repository = repository;
        } 


        public void Adicionar(LoginViewModel loginViewModel)
        {
            var LoginModel = LoginModelFactory.Criar(loginViewModel);

            _repository.Add(LoginModel);

            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
