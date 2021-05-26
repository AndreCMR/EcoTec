using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecotec.Application.ViewModel
{
    public class LoginViewModel
    {
        public Guid UsuarioId { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
