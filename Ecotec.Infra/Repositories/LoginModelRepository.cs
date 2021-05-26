using Ecotec.Infra.Data.Context;
using EcoTec.Domain.Entities;
using EcoTec.Domain.Interface.Repository;


namespace Ecotec.Infra.Data.Repositories
{
    public class RespostaReclamacaoRepository : RepositoryBase<LoginModel>, ILoginModelRepository
    {
        public RespostaReclamacaoRepository(EcotecContext context) : base(context)
        {
            //
        }

        public void Add(LoginModel loginModel)
        {
            _dbSet.Add(loginModel);

            Commit();
        }
    }
}