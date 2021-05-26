using System;

namespace EcoTec.Domain.Entities
{  
    public class Endereco
    {
        protected Endereco()
        {
            //
        }
        public Endereco(Guid enderecoId, string cep, string descricao, int numero, string bairro, int cidadeId, string complemento = "")
        {
            EnderecoId = enderecoId;
            Cep = cep;
            Descricao = descricao;
            Numero = numero;
            Bairro = bairro;
            CidadeId = cidadeId;
            Complemento = complemento;
        }
        public Guid EnderecoId { get; private set; }

        public string Cep { get; private set; }

        public string Descricao { get; private set; }

        public int Numero { get; private set; }

        public string Bairro { get; private set; }

        public string Complemento { get; private set; }

        public int CidadeId { get; private set; }

        public virtual Cidade Cidade { get; private set; }      
    }
}