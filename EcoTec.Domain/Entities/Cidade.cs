using System.Collections.Generic;

namespace EcoTec.Domain.Entities
{
    public class Cidade
    {
        protected Cidade()
        {
            //
        }

        public Cidade(int cidadeId, string descricao, EEstado estado)
        {
            CidadeId = cidadeId;
            Descricao = descricao;
            Estado = estado;
        }

        public int CidadeId { get; private set; }

        public string Descricao { get; private set; }
        
        public EEstado Estado { get; private set; }

        public ICollection<Endereco> Enderecos { get; private set; }
    }
}