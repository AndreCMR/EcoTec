using System;
using System.ComponentModel.DataAnnotations;


namespace EcoTec.Domain.Entities
{
    public class LoginModel
    {
        public LoginModel(Guid usuarioId,string login, string senha)
        {
            UsuarioId = usuarioId;
            Login = login;
            Senha = senha;
        }

        public Guid UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }

        [Required]
        [Display(Name = "Usuário")]
        public string Login { get; private set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; private set; }
    }
}
