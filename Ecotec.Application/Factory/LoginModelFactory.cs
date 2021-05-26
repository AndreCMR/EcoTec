using EcoTec.Domain.Entities;

using Ecotec.Application.ViewModel;
namespace Ecotec.Application.Factory
{
    public static class LoginModelFactory
    {
        public static LoginModel Criar(LoginViewModel loginModel)
        {
            var loginViewModel = new LoginModel(loginModel.UsuarioId, loginModel.Login, loginModel.Senha);

            return loginViewModel;
        }
    }
}
