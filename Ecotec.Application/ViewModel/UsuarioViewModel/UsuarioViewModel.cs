using Ecotec.Application.ViewModel.Enum;
using Ecotec.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecotec.Application.ViewModel
{
    public class UsuarioViewModel
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public int CPF { get; private set; }

        public EnderecoViewModel Endereco { get; private set; }

        public ETipoUsuario TipoUsuario { get; private set; }

        public byte[] ImagemUsuario { get; private set; }
    }
}
