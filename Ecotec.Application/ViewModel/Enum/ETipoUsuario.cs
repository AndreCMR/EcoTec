using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecotec.Application.ViewModel.Enum
{
    public enum ETipoUsuario
    {
        [Display(Name = "Prestador de Serviços")]
        PrestadorServicos = 1,
        Contratante = 2
    }
}
