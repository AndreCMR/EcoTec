using EcoTec.Domain.Enum;
using System;

namespace EcoTec.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public int CPF { get; private set; }

        public Endereco Endereco { get; private set; }

        public ETipoUsuario TipoUsuario { get; private set; }

        public byte[] ImagemUsuario { get; private set; }
    }
}
