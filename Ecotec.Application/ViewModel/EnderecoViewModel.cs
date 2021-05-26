using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecotec.Application.ViewModel
{
   public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            //
        }

        [Key]
        public Guid EnderecoId { get; set; }
        [DisplayName("CEP"), Required]

        public string Cep { get; set; }
        [DisplayName("Descrição"), Required]

        public string Descricao { get; set; }
        [StringLength(100)]

        public string Complemento { get; set; }
        [DisplayName("Número"), Required]

        public int Numero { get; set; }
        [Required]

        public string Bairro { get; set; }
        [Required]

        public int CidadeId { get; set; }

        public virtual CidadeViewModel Cidade { get; set; }
    }
}
