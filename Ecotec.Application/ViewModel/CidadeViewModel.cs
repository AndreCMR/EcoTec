using Ecotec.Application.ViewModel.Enum;
using System.Collections.Generic;

namespace Ecotec.Application.ViewModel
{
    public class CidadeViewModel
    {
        public int CidadeId { get; set; }

        public string Descricao { get; set; }

        public EEstado Estado { get; set; }

        public virtual ICollection<EnderecoViewModel> Enderecos { get; set; }
    }
}
